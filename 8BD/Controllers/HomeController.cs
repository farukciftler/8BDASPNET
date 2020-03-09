using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _8BD.Models;
using _8BD.Helpers;
using RestSharp;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace _8BD.Controllers
{
    public class HomeController : Controller
    {
  


        public IActionResult Index()
        {
            //var c = _httphelper.GetApiEndpoint<AuthToken>("http://localhost:63502/api/login?username=loquat&password=sifreyiunutma");

            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
