using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace _8BD.Controllers
{
    public class LoginController : Controller
    {
        IConfiguration configuration;


        public LoginController( IConfiguration configuration)
        {
        
            this.configuration = configuration;

        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + $"/login?username={username}&password={password}");

            var restResponse = restClient.Get(restRequest);
            string response = restResponse.Content;
            var jObject = JObject.Parse(restResponse.Content);
            string token = jObject.GetValue("token").ToString();
            if(token != null)
            {
                // https://benjii.me/2016/07/using-sessions-and-httpcontext-in-aspnetcore-and-mvc-core/
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("token", token);

            }
            return Redirect("Home");

        }
    }
}