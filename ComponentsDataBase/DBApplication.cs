
using System;
using System.Threading;

namespace ComponentsDBService
{
    class DBApplication
    {
        //Propiedades
        //Private
        private Thread Thread;
        private ThreadExceptionEventHandler a;
        private HTTPServer Server;
        private bool isAlive;

        //Metodos
        //Private

        //Public
        public DBApplication()
        {
            this.Server = new HTTPServer();
            this.isAlive = false;
        }

        public void Run()
        {
            this.isAlive = true;
            while(this.isAlive)
            {
                string request = this.Server.Recieve();
            }
        }
        public void Shutdown()
        {
            this.Server.Stop();
        }
    }
}
