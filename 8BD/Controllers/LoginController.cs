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
using _8BD.Models;

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
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddUser(string username, string password, string email)
        {
            User user = new User();
            user.username = username;
            user.password = password;
            user.email = email;
            _helper.PostMethod<User>(user, "/Users");
            return Redirect("../Home/Index");
        }

    }
}