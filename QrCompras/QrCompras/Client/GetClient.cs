using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QrCompras.Client
{
    public class GetClient
    {
        public string GetService(
            string Url, 
            string resource, 
            Dictionary<string, string> Headers = null,
            Dictionary<string, string> QueryString = null
            )
        {
            //Todo Ler dicionarios
            var client = new RestClient(Url);
            var request = new RestRequest(resource, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content; 


            return content;
        }
    }
}