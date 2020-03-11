using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using RestSharp;
using _8BD.Helpers;

namespace _8BD.Controllers
{
    public class LoginController : Controller
    {
        IConfiguration configuration;
        const string SessionName = "_username";
        const string SessionPass = "_token";
        private readonly HttpHelper _helper;
        public LoginController( IConfiguration configuration, HttpHelper helper)
        {
        
            this.configuration = configuration;
            _helper = helper;

        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {

            var token = _helper.GetToken(username, password);
            if(token != null)
            {
                //
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