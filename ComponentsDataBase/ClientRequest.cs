
namespace ComponentsDataBaseService
{
    public enum RequestType
    {
        Add,Delete,Update,Search
    }
    
    public class ClientRequest
    {
        public RequestType Type { get; private set; }
        public string Message { get; private set; }
        public void setType(RequestType type)
        {
            this.Type = type;
        }
        public void setMessage(string msg)
        {
            this.Message = msg;
        }
        static public ClientRequest Empty
        {
            get
            {
                ClientRequest req = new ClientRequest();
                req.Message = string.Empty;
                req.Type = RequestType.Search;
                return req;
            }
        }
    }
}
