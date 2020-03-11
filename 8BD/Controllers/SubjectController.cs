using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _8BD.Helpers;
using RestSharp;
using _8BD.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace _8BD.Controllers
{

    public class SubjectController : Controller
    {
        private readonly HttpHelper _helper;
        IConfiguration configuration;

        public SubjectController(IConfiguration configuration, HttpHelper helper)
        {
            this.configuration = configuration;
            _helper = helper;
        }
        [HttpGet]
        public IActionResult Index(string search)
        
        {

            if(search != null)
            {
                var sub = _helper.GetApiEndpointSearch(search);
                var apiendpoint = "/entries/subjectid/" + sub.id.ToString();
                var entries = _helper.GetApiEndpoint<Entry>(apiendpoint);
                ViewBag.Subject = search;
                ViewBag.Entries = entries;
                ViewBag.Count = entries.Count();
            }
            
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");

            return View();
        }
      
    }
}