using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _8BD.Helpers;
using Microsoft.Extensions.Configuration;
using _8BD.Models;
using Microsoft.AspNetCore.Http;


namespace _8BD.Controllers
{
    public class EntryController : Controller
    {
        IConfiguration configuration;
        private readonly HttpHelper _helper;
       
        public EntryController(IConfiguration configuration, HttpHelper helper)
        {
            this.configuration = configuration;
            _helper = helper;
        }
        [HttpPost]
        public IActionResult Index(string entry, string subject)
        {
            Entry ent = new Entry();
            ent.entry = entry;
            ent.subject = subject;
            var token = HttpContext.Session.GetString("_token");
            _helper.PostMethod<Entry>(ent, "/Entries", token);
            var subjecturl = configuration["AppHost"] +"/subject?search="+subject;
            return Redirect(subjecturl);
        }
    }
}