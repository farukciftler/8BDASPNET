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
            ViewBag.mostlikedentries = _helper.GetApiEndpoint<List<Entry>>("/entries/mostlikedentries?authorId=" + model.id);
            ViewBag.mostunlikedentries = _helper.GetApiEndpoint<List<Entry>>("/entries/mostunlikedentries?authorId=" + model.id);
            ViewBag.mostfavoritedentries = _helper.GetApiEndpoint<List<Entry>>("/entries/mostfavoritedentries?authorId=" + model.id);

            return View(model);
        }
        [HttpGet("ego")]
        public IActionResult MyUser()
        {
            var userid = HttpContext.Session.GetInt32("_id");
            var model = _helper.GetApiEndpoint<User>("/users/username/" + userid);
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View("Index",model);
        }

        [HttpGet]
        public IActionResult AllEntries(int authorId, int pageIndex =0)

        {

            var model = _helper.GetApiEndpoint<User>("/users/username/" + authorId);

            if (authorId != 0)
            {


                try
                {
                    
                    var apiendpoint = "/entries/allentries?authorId=" + authorId + "&pageIndex=" + pageIndex;
                    var entries = _helper.GetApiEndpoint<List<Entry>>(apiendpoint);
               
                    ViewBag.Entries = entries;
                    ViewBag.Index = pageIndex;
                    ViewBag.Count = entries.Count();
                    ViewBag.pageIndex = pageIndex;
                    ViewBag.AuthorId = authorId;
                }
                catch (Exception)
                {

                    return View("~/Views/Home/Index.cshtml");
                }


            }
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Level = HttpContext.Session.GetInt32("_level");
            ViewBag.UserId = HttpContext.Session.GetInt32("_id");

            return View(model);
        }
        [HttpGet]
        public IActionResult MostLikedEntries(int authorId, int pageIndex = 0)

        {

            var model = _helper.GetApiEndpoint<User>("/users/username/" + authorId);

            if (authorId != 0)
            {


                try
                {

                    var apiendpoint = "/entries/mostlikedentries?authorId=" + authorId + "&pageIndex=" + pageIndex;
                    var entries = _helper.GetApiEndpoint<List<Entry>>(apiendpoint);

                    ViewBag.Entries = entries;
                    ViewBag.Index = pageIndex;
                    ViewBag.Count = entries.Count();
                    ViewBag.pageIndex = pageIndex;
                    ViewBag.AuthorId = authorId;
                }
                catch (Exception)
                {

                    return View("~/Views/Home/Index.cshtml");
                }


            }
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Level = HttpContext.Session.GetInt32("_level");
            ViewBag.UserId = HttpContext.Session.GetInt32("_id");

            return View(model);
        }
        public IActionResult MostUnlikedEntries(int authorId, int pageIndex = 0)

        {

            var model = _helper.GetApiEndpoint<User>("/users/username/" + authorId);

            if (authorId != 0)
            {


                try
                {

                    var apiendpoint = "/entries/mostunlikedentries?authorId=" + authorId + "&pageIndex=" + pageIndex;
                    var entries = _helper.GetApiEndpoint<List<Entry>>(apiendpoint);

                    ViewBag.Entries = entries;
                    ViewBag.Index = pageIndex;
                    ViewBag.Count = entries.Count();
                    ViewBag.pageIndex = pageIndex;
                    ViewBag.AuthorId = authorId;
                }
                catch (Exception)
                {

                    return View("~/Views/Home/Index.cshtml");
                }


            }
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Level = HttpContext.Session.GetInt32("_level");
            ViewBag.UserId = HttpContext.Session.GetInt32("_id");

            return View(model);
        }
        public IActionResult MostFavoritedEntries(int authorId, int pageIndex = 0)

        {

            var model = _helper.GetApiEndpoint<User>("/users/username/" + authorId);

            if (authorId != 0)
            {


                try
                {

                    var apiendpoint = "/entries/mostfavoritedentries?authorId=" + authorId + "&pageIndex=" + pageIndex;
                    var entries = _helper.GetApiEndpoint<List<Entry>>(apiendpoint);

                    ViewBag.Entries = entries;
                    ViewBag.Index = pageIndex;
                    ViewBag.Count = entries.Count();
                    ViewBag.pageIndex = pageIndex;
                    ViewBag.AuthorId = authorId;
                }
                catch (Exception)
                {

                    return View("~/Views/Home/Index.cshtml");
                }


            }
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Level = HttpContext.Session.GetInt32("_level");
            ViewBag.UserId = HttpContext.Session.GetInt32("_id");

            return View(model);
        }
    }
}