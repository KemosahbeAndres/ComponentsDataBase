using CDB;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Threading;

namespace ServiceTest
{
    
    class DBApplication
    {
//####### Propiedades #######
        //Private
        private readonly HttpServer Server;
        private readonly FileManagement fileManagement;
        private DataBaseRequest serverQuery;

        //Public
        public static bool Running { get; private set; }

        //####### Metodos #######
        //Private

        //Public
        public DBApplication()
        {
            this.Server = new HttpServer("http://localhost:12701/");
            Console.WriteLine("Server Creado.");
            this.Server.OnRequest += OnServerRequest;
            Running = false;
            this.fileManagement = new FileManagement();
        }

        private string OnServerRequest(HttpListenerRequest request)
        {
            Console.WriteLine("#########################");
            Console.WriteLine("[APP] Llego una peticion de cliente");
            if (!request.HasEntityBody)
            {
                return string.Empty;
            }
            System.IO.Stream body = request.InputStream;
            Encoding encoding = request.ContentEncoding;
            System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);
            Console.WriteLine("##########################");
            Console.WriteLine("[APP][Mensaje] "+reader.ReadToEnd());
            Console.WriteLine("##########################");
            try
            {
                //var query = 
                //serverQuery = new DataBaseRequest();
                DataBaseRequest serverQuery =  JsonConvert.DeserializeObject<DataBaseRequest>(
                    reader.ReadToEnd(),
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    ContractResolver = new ConverterContractResolver()});
                //serverQuery.setType(query.Type);
                //if(query.Components != null)serverQuery.addComponentList(query.Components);
                //if(query.Querys != null)serverQuery.addQueryList(query.Querys);
            }catch(JsonSerializationException e)
            {
                Console.WriteLine("#####################");
                Console.WriteLine("[APP] Error Json: "+e.Message);
                Console.WriteLine("#####################");
                return "<h1>ERROR</h1><p>"+e.Message+"</p>";
            }
            if(serverQuery.Type == RequestType.Empty || serverQuery.Components == null)
            {
                Console.WriteLine("##############################");
                Console.WriteLine("[APP] Peticion vacia.");
                Console.WriteLine("##############################");
                return "<h1>ERROR</h1><p>La peticion esta vacia. Por favor envie una peticion con algo de informacion.</p>";
            }
            //if(serverQuery.Components == null)
            Console.WriteLine("##########################");
            Console.WriteLine("[APP] Enviando Respuesta. OK");
            Console.WriteLine("##########################");
            return "<h1>Hola Mundo.</h1>";
        }
        private void AppProcess()
        {
            Console.WriteLine("##########################");
            Console.WriteLine("[APP] AppThread iniciado: " + Thread.CurrentThread.Name);
            Console.WriteLine("##########################");
            try
            {
                Console.WriteLine("##########################");
                Console.WriteLine("[APP] Iniciando el Servidor.");
                Console.WriteLine("##########################");
                //while (Running)
                //{
                    Console.Write(".");
                    this.Server.Start();
                //}
                Console.ReadKey();
                Console.ReadKey();
                Console.ReadKey();
            }
            catch { }
            finally
            {
                Console.WriteLine("##########################");
                Console.WriteLine("[APP] Apagando el Servidor.");
                Console.WriteLine("##########################");
                try
                {
                    this.Server.Stop();
                }
                catch (Exception e)
                {
                    Console.WriteLine("##########################");
                    Console.WriteLine("[APP][ERROR][0] Problema al detener el servidor. ### "+e.Message);
                    Console.WriteLine("##########################");
                }
            }
        }

        public void Run()
        {
            Running = true;
            //ThreadPool.QueueUserWorkItem(new WaitCallback(AppProcess));
            AppProcess();
        }
        public void Shutdown()
        {
            Console.WriteLine("##########################");
            Console.WriteLine("[APP] Deteniendo Aplicacion.");
            Console.WriteLine("##########################");
            Running = false;
            try
            {
                if (HttpServer.isAlive) this.Server.Stop();
            }catch(Exception e)
            {
                Console.WriteLine("##########################");
                Console.WriteLine("[APP][ERROR][1] Problema al detener el servidor.");
                Console.WriteLine("##########################");
            }
        }
    }
}
