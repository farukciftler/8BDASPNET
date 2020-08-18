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
    public class MessageController : Controller
    {
        private readonly HttpHelper _helper;

        public MessageController(HttpHelper helper)
        {
            _helper = helper;

        }
        public IActionResult Index()
        {
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View();
        }
        public IActionResult NewMessage()
        {
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View();
        }

        [HttpPost]
        public IActionResult Send(string receiver, string msg)
        {
            var UserId = HttpContext.Session.GetInt32("_id");
            Message message = new Message();
            message.message = msg;
            message.senderId = (int)UserId;
            message.chatId = 0;
            message.id = 0;
            message.createDate = DateTime.Now;
            var apiendpoint = $"/users/usernametoid/{receiver}";
            message.receiverId = _helper.GetApiEndpoint<int>(apiendpoint);
            _helper.PostMethod<Message>(message, "/messages");
            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View("~/Views/Home/Index.cshtml");

        }
    }
}
