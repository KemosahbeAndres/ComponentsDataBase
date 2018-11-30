using System;
using System.Net;
using System.Threading;

namespace ComponentsDataBaseService
{
    class DBApplication
    {
//####### Propiedades #######
        //Private
        private Thread Thread;
        private ThreadStart threadStart;
        private ThreadExceptionEventHandler ThreadExceptionEventHnd;
        private HttpServer Server;
        private bool managerBussy;
        private FileManagement fileManagement;

        //Public
        public bool Running { get; private set; }

        //####### Metodos #######
        //Private

        //Public
        public DBApplication()
        {
            this.Server = new HttpServer("http://localhost:12701/");
            this.Server.OnRequest += onServerRequest;
            this.Running = false;
            this.managerBussy = false;
            this.fileManagement = new FileManagement();
        }

        private string onServerRequest(HttpListenerRequest request)
        {
            string message = "";
            foreach(string s in request.Headers)
            {
                message += s;
            }
            return message;
        }

        public void Run()
        {
            ThreadPool.QueueUserWorkItem((arg)=> 
            {
                try
                {

                }
                catch { }
                finally
                {
                    this.Server.Stop();
                }
                while (this.Running)
                {
                    this.Server.Start();
                }
            });
        }
        public void Shutdown()
        {
            this.Running = false;
            if(this.Server.Running) this.Server.Stop();
        }
    }
}
