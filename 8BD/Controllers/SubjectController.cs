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
        private readonly SidebarHelper _sidebar;
        IConfiguration configuration;

        public SubjectController(IConfiguration configuration, HttpHelper helper, SidebarHelper sidebar)
        {
            this.configuration = configuration;
            _helper = helper;
            _sidebar = sidebar;
        }
        //[HttpGet("[controller]/{search}/{pageIndex}")]
        [HttpGet]
        public IActionResult Index(string search, int pageIndex = 0)
        
        {

            if(search != null)
            {
                var sub = _helper.GetApiEndpointSearch(search);
                var apiendpoint = "/entries?subjectId=" + sub.id.ToString() + "&pageIndex=" +pageIndex;
                var entries = _helper.GetApiEndpoint<List<Entry>>(apiendpoint);
                ViewBag.Subject = search;
                ViewBag.SubjectId = sub.id;
                ViewBag.Entries = entries;
                ViewBag.Index = pageIndex;
                ViewBag.Count = entries.Count();
                ViewBag.pageIndex = pageIndex;
            }
            
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Level = HttpContext.Session.GetInt32("_level");

            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, string newsubject, string oldsubject)
        {
            var apiendpoint = $"/subjects/edit/{id}/{newsubject}";
            var entry = _helper.GetApiEndpoint<Entry>(apiendpoint);
            return Redirect($"/subject?search={newsubject}");
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var apiendpoint = $"/subjects/delete/{id}";
            var entry = _helper.GetApiEndpoint<Entry>(apiendpoint);
            return View("~/Views/Home/Index.cshtml");
        }


        public ActionResult GetPaggedData(int pageNumber = 1, int pageSize = 20)
        {
            IOrderedEnumerable<Subject> listData = _sidebar.getSubjectsTwo(pageNumber,pageSize);
            var pagedData = Pagination.PagedResult(listData, pageNumber, pageSize);

            return Json(pagedData);
        }
      
    }
}