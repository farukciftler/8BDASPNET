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

        [HttpGet("entryedit")]
        public IActionResult EntryEdit()
        {

            return View("~/Views/Subject/Button/EntryEdit.cshtml");
        }
        [HttpGet("entrytransfer")]
        public IActionResult EntryTransfer()
        {

            return View("~/Views/Subject/Button/EntryTransfer.cshtml");
        }
        [HttpGet("subjectedit")]
        public IActionResult SubjectEdit()
        {

            return View("~/Views/Subject/Button/SubjectEdit.cshtml");
        }
        [HttpGet("subjectdelete")]
        public IActionResult SubjectDelete()
        {

            return View("~/Views/Subject/Button/SubjectDelete.cshtml");
        }
        [HttpGet("entrydelete")]
        public IActionResult EntryDelete()
        {

            return View("~/Views/Subject/Button/EntryDelete.cshtml");
        }
    }
}