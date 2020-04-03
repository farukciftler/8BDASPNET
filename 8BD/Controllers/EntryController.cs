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
        [HttpGet("[controller]/{search}/{entryid}")]
        public IActionResult Index(string search, int entryid)
        {
            if (search != null)
            { 
                var apiendpoint = "/entries/" + entryid.ToString();
                
                var entry = _helper.GetApiEndpoint<Entry>(apiendpoint);
               
                ViewBag.Entry = entry;
                ViewBag.Subject = search;
            }

            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");


            return View("~/Views/Subject/SingleEntry.cshtml");
        }
        [HttpPost]
        public IActionResult AddEntry(string entry, int subjectId=0, string subject=null)
        {
            Entry ent = new Entry();
            ent.entry = entry;
            var d = 0;
            var token = HttpContext.Session.GetString("_token");
            if (subjectId == 0)
            {
                d = _helper.GetSubjectIdByName(subject);
                if (d == 0)
                {
                    Subject newsubject = new Subject();
                    newsubject.subject = subject;
                    var c= _helper.PostMethod<Subject>(newsubject, "/subjects", token);

                    ent.subjectId = c.id;
                }
                else
                {
                    ent.subjectId = d;
                }
                

            }
            else
            {
                ent.subjectId = subjectId;
            }
            
            
            
            
            _helper.PostMethod<Entry>(ent, "/Entries", token);
            subject =String.Join(
            "/",
            subject.Split("/").Select(s => System.Net.WebUtility.UrlEncode(s))
            );
            var subjecturl = configuration["AppHost"] + "/subject?search=" + subject;
            return Redirect(subjecturl);
        }
    }
}