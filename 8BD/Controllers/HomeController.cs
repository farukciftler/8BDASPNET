using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _8BD.Models;
using _8BD.Helpers;
using _8BD.Controllers;
using RestSharp;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace _8BD.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration configuration;
        public HomeController(IConfiguration configuration)
        {

            this.configuration = configuration;

        }

        public IActionResult Index()
        {
            //var c = _httphelper.GetApiEndpoint<AuthToken>("http://localhost:63502/api/login?username=loquat&password=sifreyiunutma");
            //IList<Subject> subjects = new List<Subject>();
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + $"/subjects");
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<List<Subject>>(restResponse.Content);
            ViewBag.Subject = subjects;
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
