using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _8BD.Controllers
{
    public class ButtonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // return View("~/Views/Subject/SingleEntry.cshtml");

        [HttpGet("entryedit/{id}")]
        public IActionResult EntryEdit(int id)
        {
            ViewBag.id = id;
            return View("~/Views/Subject/Button/EntryEdit.cshtml");
        }
        [HttpGet("entrytransfer/{id}")]
        public IActionResult EntryTransfer(int id)
        {
            ViewBag.id = id;
            return View("~/Views/Subject/Button/EntryTransfer.cshtml");
        }
        [HttpGet("entrydelete/{id}")]
        public IActionResult EntryDelete(int id)
        {
            ViewBag.id = id;
            return View("~/Views/Subject/Button/EntryDelete.cshtml");
        }
        [HttpGet("subjectedit/{id}")]
        public IActionResult SubjectEdit(int id)
        {
            ViewBag.id = id;
            return View("~/Views/Subject/Button/SubjectEdit.cshtml");
        }
        [HttpGet("subjectdelete/{id}")]
        public IActionResult SubjectDelete(int id)
        {
            ViewBag.id = id;
            return View("~/Views/Subject/Button/SubjectDelete.cshtml");
        }
        [HttpGet("subjecthide/{id}")]
        public IActionResult SubjectHide(int id)
        {
            ViewBag.id = id;
            return View("~/Views/Subject/Button/SubjectHide.cshtml");
        }

    }
}