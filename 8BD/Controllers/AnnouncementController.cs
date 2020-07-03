using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _8BD.Helpers;
using _8BD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _8BD.Controllers
{
    public class AnnouncementController : Controller
    {

        private readonly HttpHelper _helper;

        public AnnouncementController(HttpHelper helper)
        {
            _helper = helper;
        }

        [HttpGet("announcements")]
        public IActionResult Index()
        {
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Level = HttpContext.Session.GetInt32("_level");
            return View();
        }

        [HttpPost]
        public ActionResult Add(string announce)
        {

            Announcement announcement = new Announcement();
            announcement.announcement = announce;
            announcement.userId= (int)HttpContext.Session.GetInt32("_id");
            var apiendpoint = $"/announcements";
            _helper.PostMethod<Announcement>(announcement, apiendpoint);
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Level = HttpContext.Session.GetInt32("_level");
            return Redirect("/announcements");
        }
    }
}