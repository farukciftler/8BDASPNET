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
    public class ProfileController : Controller
    {

        private readonly HttpHelper _helper;

        public ProfileController(HttpHelper helper)
        {
            _helper = helper;
        }

        [HttpGet("profile/{username}")]
        public IActionResult Index(string username)
        {
           
            var model = _helper.GetApiEndpoint<User>("/users/username/" + username);
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View(model);
        }
    }
}