using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceTest
{
    class HttpServer
    {
        private HttpListener server;

        //Public
        public delegate string RequestMethod(HttpListenerRequest request);
        public event RequestMethod OnRequest;
        public static bool isAlive { get; private set; }

        public HttpServer(params string[] uri)
        {
            isAlive = false;
            if (!HttpListener.IsSupported)
            {
                Console.WriteLine("OBJETO HTTPLISTENER NO SOPORTADO.");
                throw new NotSupportedException("Necesario Windows XP SP2, Server 2003 o mayor.");
            }
            this.server = new HttpListener();
            foreach (var p in uri)
            {
                this.server.Prefixes.Add(p);
            }
            this.server.Start();
            Console.WriteLine("[SERVER] Start");
        }


        private void CallBack(Object listener)
        {
            try
            {
                while (this.server.IsListening || isAlive)
                {
                    Console.WriteLine("[SERVER] Escuchando...");
                    //ThreadPool.QueueUserWorkItem((c) =>
                    //{
                    var serv = listener as HttpListener;
                    var context = serv.GetContext();
                        try
                        {
                            if (context == null) return;
                            Console.WriteLine("[SERVER] Peticion recibida.");
                            var response = this.OnRequest?.Invoke(context.Request);
                            var buffer = Encoding.UTF8.GetBytes(response);
                            context.Response.ContentLength64 = buffer.Length;
                            context.Response.Headers.Add("Content-Type", "application/json");
                            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                            Console.WriteLine("[SERVER] Respuesta enviada.");
                            Console.WriteLine("[SERVER][RESPUESTA] " + response);
                        }
                        catch { }
                        finally
                        {
                            if (context != null) context.Response.OutputStream.Close();
                        }
                    //}, this.server.GetContext());
                }
            }
            catch { }
        }

        public void Start()
        {
            isAlive = true;
            Task mTask = new Task(new Action<Object>(CallBack), server);
            //ThreadPool.QueueUserWorkItem(new WaitCallback(CallBack), server);
            //CallBack();
        }

        public void Stop()
        { 
            this.server.Stop();
            isAlive = false;
            this.server.Close();
            Console.WriteLine("[SERVER] Apagando Servidor.");
        }

    }
}
