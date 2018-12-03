using System;
using System.IO;
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
            string file = @"./log";
            string ext = @".txt";
            int indice = 0;
            while (true)
            {
                if (File.Exists(file+indice+ext))
                {
                    indice++;
                }
                else
                {
                    break;
                }
                    
            }
            StreamWriter writer = File.AppendText(file + indice + ext);
            writer.WriteLine("Iniciando Hilo");
            
            try
            {
                while (this.server.IsListening || isAlive)
                {
                    Console.WriteLine("[SERVER] Escuchando...");
                    writer.WriteLine("[SERVER] Escuchando...");
                    //ThreadPool.QueueUserWorkItem((c) =>
                    //{
                    var serv = listener as HttpListener;
                    var context = serv.GetContext();
                    writer.WriteLine("[SERVER] Peticion recibida.");
                    try
                        {
                            if (context == null)
                            {
                                writer.WriteLine("[SERVER] Peticion NULA");
                                Console.WriteLine("[SERVER] Peticion NULA.");
                                return;
                            }
                            writer.WriteLine("[SERVER] Peticion corerecta");
                            Console.WriteLine("[SERVER] Peticion recibida.");
                            var response = this.OnRequest?.Invoke(context.Request);
                            var buffer = Encoding.UTF8.GetBytes(response);
                            context.Response.ContentLength64 = buffer.Length;
                            context.Response.Headers.Add("Content-Type", "application/json");
                            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                            Console.WriteLine("[SERVER] Respuesta enviada.");
                            Console.WriteLine("[SERVER][RESPUESTA] " + response);
                        }
                        catch(Exception w) {
                            writer.WriteLine("##########################");
                            writer.WriteLine("[SERVER][ERROR][1] "+w.Message);
                            writer.WriteLine("##########################");
                            Console.WriteLine("##########################");
                            Console.WriteLine("[SERVER][ERROR][1] " + w.Message);
                            Console.WriteLine("##########################");
                        }
                        finally
                        {
                            if (context != null) context.Response.OutputStream.Close();
                        }
                    //}, this.server.GetContext());
                }
            }
            catch(Exception e) {
                writer.WriteLine("##########################");
                writer.WriteLine("[SERVER][ERROR][0] " + e.Message);
                writer.WriteLine("##########################");
                Console.WriteLine("##########################");
                Console.WriteLine("[SERVER][ERROR][0]" + e.Message);
                Console.WriteLine("##########################");
            }
            
            writer.Close();
        }

        public void Start()
        {
            isAlive = true;
            
            try
            {
                //Task mTask = new Task(new Action<Object>(CallBack), server);
                //mTask.Start();
                CallBack(server);
            }catch(Exception w)
            {
                Console.WriteLine("##########################");
                Console.WriteLine("[SERVER][ERROR] "+w.Message);
                Console.WriteLine("##########################");
            }
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
