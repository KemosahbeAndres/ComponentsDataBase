﻿using System;
using System.Net;
using System.Text;
using System.Threading;

namespace ComponentsDataBaseService
{
    class HttpServer
    {
        private HttpListener server;
        private HttpListenerContext context;

        //Public
        public delegate string RequestMethod(HttpListenerRequest request);
        public event RequestMethod OnRequest;
        public static bool isAlive { get; private set; }

        public HttpServer(params string[] uri)
        {
            if (!HttpListener.IsSupported)
            {
                throw new NotSupportedException("Necesario Windows XP SP2, Server 2003 o mayor.");
            }
            this.server = new HttpListener();
            foreach (var p in uri)
            {
                this.server.Prefixes.Add(p);
            }
            this.server.Start();
        }

        public void Start()
        {
            try
            {
                while (this.server.IsListening || isAlive)
                {
                    ThreadPool.QueueUserWorkItem((c)=> 
                    {
                        var context = c as HttpListenerContext;
                        try
                        {
                            if (context == null) return;
                            var response = this.OnRequest?.Invoke(context.Request);
                            var buffer = Encoding.UTF8.GetBytes(response);
                            context.Response.ContentLength64 = buffer.Length;
                            context.Response.Headers.Add("Content-Type", "application/json");
                            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                        }
                        catch { }
                        finally
                        {
                            if (context != null) context.Response.OutputStream.Close();
                        }
                    }, this.server.GetContext());
                }
            }
            catch { }
        }
        public void Stop()
        { 
            this.server.Stop();
            isAlive = false;
            this.server.Close();
        }

    }
}
