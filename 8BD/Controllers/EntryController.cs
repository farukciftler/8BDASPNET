﻿using System;
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
                search = search.ToLower();
                var apiendpoint = "/entries/" + entryid.ToString();
                
                var entry = _helper.GetApiEndpoint<Entry>(apiendpoint);
               
                ViewBag.Entry = entry;
                ViewBag.Subject = search;
                ViewBag.subjectId = entry.subjectId;
            }

            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Pass = HttpContext.Session.GetInt32("_level");
            ViewBag.UserId = HttpContext.Session.GetInt32("_id");

            return View("~/Views/Subject/SingleEntry.cshtml");
        }

        [HttpPost]
        public ActionResult Edit(int id, string newentry)
            {
            newentry = newentry.Replace("\r\n", "<br />").Replace("\n", "<br />");
            Entry entry = new Entry();
            entry.entry = newentry;
            entry.id = id;
            var apiendpoint = $"/entries/edit";
            var final = _helper.PostMethod<Entry>(entry, apiendpoint);
            return Redirect($"/subject?search={_helper.GetSubjectNameById(final.subjectId)}");
        }
        [HttpPost]
        public ActionResult Notice(int entryid, int userid, int subjectid, string notice)
        {

            EntryNotice entryNotice = new EntryNotice();
            entryNotice.id = 0;
            entryNotice.entryId = entryid;
            entryNotice.noticedById = userid;
            entryNotice.notice = notice;
            var apiendpoint = $"/entrynotices/notice";
            _helper.PostMethod<EntryNotice>(entryNotice, apiendpoint);
            return Redirect($"/subject?search={_helper.GetSubjectNameById(subjectid)}");
        }
        [HttpPost]
        public ActionResult Delete(int id, string reason )
        {
            if (reason == null)
            {
                reason = "standart";
            }
            var apiendpoint = $"/entries/delete/{id}/{reason}";
            var entry = _helper.GetApiEndpoint<Entry>(apiendpoint);
            return View("~/Views/Home/Index.cshtml");
        }
        [HttpPost]
        public IActionResult AddEntry(string entry, int subjectId = 0, string subject = null)
        {
            Entry ent = new Entry();
            Subject newsubject = new Subject();
            newsubject.subject = subject;
            newsubject.BSHIU = "";
            entry = entry.Replace("\r\n", "<br />").Replace("\n", "<br />");
            ent.entry = entry;

            var d = 0;
            var token = HttpContext.Session.GetString("_token");
            if (subjectId == 0)
            {
                d = _helper.GetSubjectIdByName(subject);
                if (d == 0)
                {
                    
                    
                    var c = _helper.PostMethod<Subject>(newsubject, "/subjects", token);

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
            subject = String.Join(
            "/",
            subject.Split("/").Select(s => System.Net.WebUtility.UrlEncode(s))
            );
            var subjecturl = "/subject?search=" + subject;
            return Redirect(subjecturl);
        }
        
    }
}