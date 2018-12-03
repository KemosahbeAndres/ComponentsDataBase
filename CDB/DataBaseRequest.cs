using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
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
        public DataBaseRequest() { }
        public DataBaseRequest(RequestType type, List<string> querys, List<Componente> comp)
        {
            this.Type = type;
            this.Querys = querys;
            this.Components = comp;
        }
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
    public class ConverterContractResolver : DefaultContractResolver
    {
        public new static readonly ConverterContractResolver Instance = new ConverterContractResolver();

        protected override JsonContract CreateContract(Type objectType)
        {
            JsonContract contract = base.CreateContract(objectType);

            // this will only be called once and then cached
            if (objectType == typeof(DateTime) || objectType == typeof(DateTimeOffset))
            {
                contract.Converter = new JavaScriptDateTimeConverter();
            }

            return contract;
        }
    }
}
