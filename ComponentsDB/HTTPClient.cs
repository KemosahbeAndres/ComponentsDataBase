using CDB;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;


namespace ComponentsViewer
{
    class HTTPClient
    {
        private HttpClient cliente;
        private static string respuesta;
        private delegate void HTTPClientResponse(string response);
        private event HTTPClientResponse OnResponse;

        public HTTPClient()
        {
            cliente = new HttpClient();
            this.OnResponse += HTTPClient_OnResponse;
        }

        private void HTTPClient_OnResponse(string response)
        {
            respuesta = response;
        }

        public string SendRequestAsync(DataBaseRequest request)
        {
            // Este hilo envia la peticion al servidor de Base de Datos
            //de manera asincrona. Y esta manejado por ThreadPool para
            //no tener problemas con los hilos.
            ThreadPool.QueueUserWorkItem(async (args) => {
                //Guardo en la variable cRequest los argumentos(args) como DataBaseRequest
                //pasados a la funcion lambda (async (args) => {...} ),
                //OJO!!! async permite la ejecucion asyncrona del hilo.
                var cRequest = args as DataBaseRequest;
                var content = new StringContent(
                    JsonConvert.SerializeObject(
                        cRequest, 
                        Formatting.Indented, 
                        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        ContractResolver = new ConverterContractResolver()}), 
                    System.Text.Encoding.UTF8, 
                    "application/json");
                var cResponse = await cliente.PostAsync("http://localhost:12701/", content);
                StreamContent response = (StreamContent) cResponse.Content;
                if(OnResponse != null) OnResponse?.Invoke(await response.ReadAsStringAsync());
            }, request);

            return respuesta;
        }
    }
}
