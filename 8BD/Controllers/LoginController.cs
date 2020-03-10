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
        const string SessionName = "_username";
        const string SessionPass = "_password";

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
            var jObject = JObject.Parse(restResponse.Content);
            string token = jObject.GetValue("token").ToString();
            if(token != null)
            {
                // https://benjii.me/2016/07/using-sessions-and-httpcontext-in-aspnetcore-and-mvc-core/
                HttpContext.Session.SetString(SessionName, username);
                HttpContext.Session.SetString(SessionPass, token);
            }
            return Redirect("Home");

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return Redirect("../Home/Index");
        }
    }
}