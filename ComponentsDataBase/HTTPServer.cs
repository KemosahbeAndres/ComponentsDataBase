using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ComponentsDBService
{
    class HTTPServer
    {
        //Constructores
        public HTTPServer(int port = 12701)
        {
            this.sAddress = IPAddress.Any;
            this.sPort = port;
            this.sListener = new TcpListener(this.sAddress, this.sPort);
        }
        public HTTPServer(IPAddress address, int port = 12701)
        {
            this.sAddress = address;
            this.sPort = port;
            this.sListener = new TcpListener(this.sAddress, this.sPort);
        }
        public HTTPServer(string address, int port = 12701)
        {
            this.sAddress = IPAddress.Parse(address);
            this.sPort = port;
            this.sListener = new TcpListener(this.sAddress, this.sPort);
        }

        //Private
        private int sPort;
        private IPAddress sAddress;
        private TcpListener sListener;
        private TcpClient sClient;

        //Metodos

        

        //Public
        public NetworkStream clientStream = null;
        public StreamReader streamInput = null;
        public StreamWriter streamOutput = null;

        //Metodos
        public string Recieve()
        {
            try
            {
                if (this.sClient.Connected)
                {
                    this.sClient.Close();
                    this.streamInput.Close();
                    this.streamOutput.Close();
                }
                this.sListener.Start();
                this.sClient = this.sListener.AcceptTcpClient();
                clientStream = this.sClient.GetStream();
                if (clientStream.DataAvailable)
                {
                    this.streamInput = new StreamReader(clientStream);
                    this.streamOutput = new StreamWriter(clientStream);
                }
                return streamInput.ReadToEnd();
            }
            catch
            {
                //Console.WriteLine(e.Message);
            }
            return null;
        }
        public void Send(string message)
        {
            if (this.streamOutput != null || this.sClient.Connected) {
                this.streamOutput.Write(message);
            }
            else { throw new System.Exception(); }
        }
        public void Stop()
        {

        }
    }
}
