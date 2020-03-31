using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _8BD.Controllers
{
    public class AnnouncementController : Controller
    {
        [HttpGet("announcements")]
        public IActionResult Index()
        {
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View();
        }
    }
}