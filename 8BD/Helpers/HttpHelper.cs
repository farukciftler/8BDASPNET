using _8BD.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

namespace _8BD.Helpers
{
    public class HttpHelper
    {
        IConfiguration configuration;

        public HttpHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string GetToken()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiEndpoint"]+"/login").AddParameter("username", "loquat", ParameterType.UrlSegment).AddParameter("password", "sifreyiunutma", ParameterType.UrlSegment);

            var a = restClient.Get(restRequest);

            return "wesad";
        }
        public static TResponse PostApiEndpoint<TResponse, TRequest>(TRequest request, string apiEndpoint, string apiFunction, RestSharp.Method method = Method.POST, Dictionary<string, string> headers = null)
        {
            var _client = new RestClient(apiEndpoint);
            var httpReq = new RestRequest(apiFunction, method);
            if (request != null)
            {
                httpReq.AddJsonBody(request);
            }
            httpReq.RequestFormat = DataFormat.Json;
            httpReq.AddHeader("Content-type", "application/json");
           

            if (headers != null && headers.Count > 0)
            {
                foreach (var item in headers)
                {
                    httpReq.AddHeader(item.Key, item.Value);
                }
            }

            var result = _client.Execute(httpReq);

            if (result != null)
            {
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (result.Content != null)
                    {
                        TResponse response = Newtonsoft.Json.JsonConvert.DeserializeObject<TResponse>(result.Content);
                        return response;
                    }
                    else
                    {
                        return default(TResponse);
                    }
                }
                else
                {
                    return default(TResponse);
                }
            }
            else
            {
                // log here
                return default(TResponse);
            }
        }

        public static System.Net.HttpStatusCode PostApiEndpoint<TRequest>(TRequest request, string apiEndpoint, string apiFunction, RestSharp.Method method = Method.POST)
        {
            var _client = new RestClient(apiEndpoint);
            var httpReq = new RestRequest(apiFunction, method);
            if (request != null)
            {
                httpReq.AddJsonBody(request);
            }
            httpReq.RequestFormat = DataFormat.Json;
            httpReq.AddHeader("Content-type", "application/json");
            var result = _client.Execute(httpReq);

            return result.StatusCode;
        }
        public static TResponse GetToken<TResponse, TRequest>(string apiEndpoint, string apiFunction, RestSharp.Method method = Method.GET, Dictionary<string, string> headers = null)
        {
            var _client = new RestClient(apiEndpoint);
            var httpReq = new RestRequest(apiFunction, method);
            httpReq.AddHeader("Content-type", "application/json");
            if(headers != null && headers.Count > 0)
            {
                foreach (var item in headers)
                {
                    httpReq.AddHeader(item.Key, item.Value);
                }
            }

            var result = _client.Execute(httpReq);

            if (result != null)
            {
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (result.Content != null)
                    {
                        TResponse response = Newtonsoft.Json.JsonConvert.DeserializeObject<TResponse>(result.Content);
                        return response;
                    }
                    else
                    {
                        return default(TResponse);
                    }
                }
                else
                {
                    return default(TResponse);
                }
            }
            else
            {
                // log here
                return default(TResponse);
            }
        }


        public static string GetExceptionErrorMessage(Exception ex, string errorTitle)
        {
            StringBuilder errorLog = new StringBuilder();

            if (ex != null)
            {
                errorLog.AppendLine("\nMessage : \n" + ToString(ex.Message));
                errorLog.AppendLine("\nStack Trace : \n" + ToString(ex.StackTrace));
                errorLog.AppendLine("\nSource : \n" + ToString(ex.Source));
                errorLog.AppendLine("\nTarget Site : \n" + ToString(ex.TargetSite));

                if (ex.InnerException != null)
                {
                    errorLog.AppendLine("\nInner Ex. Message : \n" + ToString(ex.InnerException.Message));
                    errorLog.AppendLine("\nInner Ex. Stack Trace : \n" + ToString(ex.InnerException.StackTrace));
                    errorLog.AppendLine("\nInner Ex. Source : \n" + ToString(ex.InnerException.Source));

                    if (ex.InnerException.InnerException != null)
                    {
                        errorLog.AppendLine("\nInner Ex. of Inner Ex. Message : \n" + ToString(ex.InnerException.InnerException.Message));
                        errorLog.AppendLine("\nInner Ex. of Inner Ex. Stack Trace : \n" + ToString(ex.InnerException.InnerException.StackTrace));
                        errorLog.AppendLine("\nInner Ex. of Inner Ex. Source : \n" + ToString(ex.InnerException.InnerException.Source));

                    }
                }
            }

            return errorLog.ToString();
        }

        public TResponse GetApiEndpoint<TResponse>(string apiEndpoint, RestSharp.Method method = Method.GET)
        {
            return PostApiEndpoint<TResponse, IRestRequest>(null, apiEndpoint, null, method);
        }

       /* public string GetToken()
        {
            // Get Token
            var client = new RestClient("http://localhost:63502/api/login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"username\": \"farukciftler\", \"password\": \"sifreyiunutma\"}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            var d = JsonConvert.DeserializeObject<List<AuthToken>>(response.Content);

            var token = "dsass";

            return token;
        }*/
        public static string ToString(object parseValue)
        {
            return ToString(parseValue, string.Empty);
        }

        /// <summary>
        /// Parses the given input value and converts it to a string.
        /// </summary>
        /// <param name="parseValue">The input value to parse</param>
        /// <param name="defaultValue">The default value to return in case of failure to convert the given input</param>
        /// <returns>The converted string value</returns>
        public static string ToString(object parseValue, string defaultValue)
        {
            if (parseValue == null || parseValue == DBNull.Value) return defaultValue;
            string returnValue;
            try
            {
                returnValue = parseValue.ToString();
            }
            catch
            {
                returnValue = defaultValue;
            }
            return returnValue;
        }
    }
}
