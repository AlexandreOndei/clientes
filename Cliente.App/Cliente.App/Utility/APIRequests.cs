using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Cliente.App.Utility
{
    public static class APIRequests
    {
        public static IList<DTO.Clientes.ClienteViewModel> GetClientes(string filtro)
        {
            return CallMethod<IList<DTO.Clientes.ClienteViewModel>>("Clientes", Method.GET, GetParam("filtro", filtro));
        }

        private static KeyValuePair<string, object> GetParam(string key, object value)
        {
            return new KeyValuePair<string, object>(key, value);
        }

        private static IRestRequest GetRequest(string resource, Method method, Dictionary<string, object> parameters)
        {
            RestRequest request = new RestRequest(resource, method);
            
            foreach (var param in parameters)
                request.AddParameter(param.Key, param.Value);

            return request;
        }

        private static IRestResponse<T> GetResponse<T>(IRestRequest request)
        {
            string url = ConfigurationManager.AppSettings["UrlApi"];
            RestClient client = new RestClient(url);
            return client.Execute<T>(request);
        }

        private static T CallMethod<T>(string resource, Method method, params KeyValuePair<string, object>[] parameters) where T : class
        {
            IRestRequest request = GetRequest(resource, method, parameters.ToDictionary(x => x.Key, y => y.Value));
            IRestResponse<T> response = GetResponse<T>(request);
            T retorno = null;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                retorno = response.Data;

            return retorno;
        }
    }
}