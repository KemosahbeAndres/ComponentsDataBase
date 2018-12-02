using System.Collections.Generic;

namespace CDB
{
    public enum RequestType
    {
        Add,Delete,Update,Search,Empty
    }
    
    public class DataBaseRequest
    {
        public RequestType Type { get; private set; }
        public List<string> Querys { get; private set; }
        public List<Componente> Components { get; private set; }
        public void setType(RequestType type)
        {
            this.Type = type;
        }
        public void addQuery(string query)
        {
            this.Querys.Add(query);
        }
        public void addQueryList(List<string> collection)
        {
            this.Querys.AddRange(collection);
        }
        public void addComponent(Componente item)
        {
            this.Components.Add(item);
        }
        public void addComponentList(List<Componente> collection)
        {
            this.Components.AddRange(collection);
        }
        public static DataBaseRequest Empty
        {
            get
            {
                DataBaseRequest req = new DataBaseRequest();
                req.Type = RequestType.Empty;
                return req;
            }
        }
    }
}
