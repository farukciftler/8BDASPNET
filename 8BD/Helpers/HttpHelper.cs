using _8BD.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using System.Net;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace _8BD.Helpers
{
    public class HttpHelper
    {
        IConfiguration configuration;
        public HttpHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string GetToken(string username, string password)
        {

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + $"/login?username={username}&password={password}");
            var restResponse = restClient.Get(restRequest);
            string token = null;
            if(restResponse.Content !="")
            { 
                var jObject = JObject.Parse(restResponse.Content);
                 token = jObject.GetValue("token").ToString();
                if (jObject.GetValue("token")!=null)
                {
                    token = jObject.GetValue("token").ToString();
                }
            }
            return token; 
        }
        public T GetApiEndpoint<T>(string apiendpoint)
        {

            
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + apiendpoint);
            var restResponse = restClient.Get(restRequest);
            var deserializedobject = JsonConvert.DeserializeObject<T>(restResponse.Content);

            return deserializedobject;
        }
        public string GetUsername(int userid)
        {


            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/users/userid/" + userid);
            var restResponse = restClient.Get(restRequest);
            var deserializedobject = "uçukyazar";
            if (restResponse.StatusCode.ToString() !="NotFound")
            {
                deserializedobject = JsonConvert.DeserializeObject<string>(restResponse.Content);
                
            }


                return deserializedobject;
        }


        public int GetSubjectIdByName(string search)
        {


            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/subjects/title/" + search);
            var restResponse = restClient.Get(restRequest);

            var deserializedobject = JsonConvert.DeserializeObject<Subject>(restResponse.Content);
           
            

            return deserializedobject.id;
        }
       

        public Entry GetEntryById(int search)
        {


            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/entries/" + search);
            var restResponse = restClient.Get(restRequest);

            var deserializedobject = JsonConvert.DeserializeObject<Entry>(restResponse.Content);



            return deserializedobject;
        }
        public string GetSubjectNameById(int search)
        {


            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/subjects/id/" + search);
            var restResponse = restClient.Get(restRequest);

            var deserializedobject = JsonConvert.DeserializeObject<Subject>(restResponse.Content);



            return deserializedobject.subject;
        }
        

        public Subject GetApiEndpointSearch(string search)
        {

          
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/subjects/title/"+search);
            var restResponse = restClient.Get(restRequest);
             var deserializedobject = JsonConvert.DeserializeObject<Subject>(restResponse.Content);
            return deserializedobject;
        }
        public T PostMethod<T>(object obj, string uri, string bearerToken = null, Dictionary<string, string> headers = null)
         {
            var client = new RestClient(configuration["ApiAddress"] + uri);
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            if (bearerToken != null)
            {
                request.AddHeader("Authorization", string.Format("Bearer {0}", bearerToken));
                request.AddHeader("Accept", "application/json; charset=utf-8"); //İŞE YARAMIYOR


            }
            else
            {
                request.AddHeader("Accept", "application/json; charset=utf-8");
            }

            var result = GetResult<T>(client, request, obj, headers);

            return result;
        }

        private T GetResult<T>(RestClient client, RestRequest request, object obj = null, Dictionary<string, string> headers = null)
        {
            
            if (headers != null) //header varsa requeste headerları ekle
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                    request.AddHeader("Accept", "application/json; charset=utf-8");
                }
            }

            if (obj != null) //post,put,delete gibi işlemler için servise gönderilecek nesne varsa requeste ekle
            {
                request.AddJsonBody(obj);

            }
            //client üzerinden requesti servise yolla ve
            var response = client.Execute(request);
           

            return JsonConvert.DeserializeObject<T>(response.Content, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

        }


    }
}
