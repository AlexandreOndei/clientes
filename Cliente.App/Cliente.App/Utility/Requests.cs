using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Cliente.App.Utility
{
    public static class Requests
    {
        public static IList<DTO.Clientes.ClienteViewModel> GetClientes()
        {
            return Get<DTO.Clientes.ClienteViewModel>("Clientes");
        }

        private static IList<T> Get<T>(string resource) where T : class
        {
            string url = ConfigurationManager.AppSettings["UrlApi"];
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(resource, Method.GET);
            IRestResponse<List<T>> response = client.Execute<List<T>>(request);
            List<T> retorno = null;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                retorno = response.Data;

            return retorno;
        }
    }
}