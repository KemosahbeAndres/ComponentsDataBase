using CDB;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace ComponentsDataBaseService
{
    class DBApplication
    {
//####### Propiedades #######
        //Private
        private readonly HttpServer Server;
        private readonly FileManagement fileManagement;
        private ServerQuery serverQuery;

        //Public
        public static bool Running { get; private set; }

        //####### Metodos #######
        //Private

        //Public
        public DBApplication()
        {
            this.Server = new HttpServer("http://localhost:12701/");
            this.Server.OnRequest += OnServerRequest;
            Running = false;
            this.fileManagement = new FileManagement();
        }

        private string OnServerRequest(HttpListenerRequest request)
        {
            if (!request.HasEntityBody)
            {
                return string.Empty;
            }
            System.IO.Stream body = request.InputStream;
            Encoding encoding = request.ContentEncoding;
            System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);
            try
            {
                serverQuery = JsonConvert.DeserializeObject<ServerQuery>(reader.ReadToEnd());
            }catch(JsonSerializationException e)
            {
                return "<h1>ERROR</h1><p>"+e.Message+"</p>";
            }
            if(serverQuery.Type == RequestType.Empty || serverQuery.Components.Count <= 0)
            {
                return "<h1>ERROR</h1><p>La peticion esta vacia. Por favor envie una peticion con algo de informacion.</p>";
            }

            return string.Empty;
        }

        public void Run()
        {
            try
            {
                while (Running)
                {
                    this.Server.Start();
                }
            }
            catch { }
            finally
            {
                this.Server.Stop();
            }          
        }
        public void Shutdown()
        {
            Running = false;
            if(HttpServer.isAlive) this.Server.Stop();
        }
    }
}
