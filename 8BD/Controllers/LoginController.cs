using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using RestSharp;
using _8BD.Helpers;
using _8BD.Models;

namespace _8BD.Controllers
{
    public class LoginController : Controller
    {
        IConfiguration configuration;
        const string SessionName = "_username";
        const string SessionPass = "_token";
        const string SessionLevel = "_level";
        const string SessionId = "_id";
        private readonly HttpHelper _helper;
        public LoginController( IConfiguration configuration, HttpHelper helper)
        {
        
            this.configuration = configuration;
            _helper = helper;

        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
           
            var token = _helper.GetToken(username, password);
            if(token != null)
            {
                var apiendpoint =$"/users/username/{username}" ;
                var user = _helper.GetApiEndpoint<User>(apiendpoint);
                HttpContext.Session.SetInt32(SessionLevel, user.userLevel);
                HttpContext.Session.SetInt32(SessionId, user.id);
                HttpContext.Session.SetString(SessionName, username);
                HttpContext.Session.SetString(SessionPass, token);
                ViewBag.Message = "Başarıyla giriş yaptınız";
            }
            else
            {
                ViewBag.Message = "Kullanıcı adınız veya şifreniz hatalı!";
                return View();
            }

            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            return View("../Home/Index");

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return Redirect("../Home/Index");
        }
        public IActionResult RegisterContract()
        {
            

            return View();
        }
        public IActionResult IndexPage()
        {

            ViewBag.Name = HttpContext.Session.GetString("_username");
            ViewBag.Pass = HttpContext.Session.GetString("_password");
            ViewBag.Pass = HttpContext.Session.GetInt32("_level");
            ViewBag.UserId = HttpContext.Session.GetInt32("_id");
            return View("./Index");
        }
        public IActionResult Register()
        {

            return View();
        }
        public IActionResult ForgotPassword()
        {

            return View();
        }
        [HttpPost]
        public IActionResult RecoverPassword(string email)
        {
            User user = new User();
            user.email = email;
            var c = _helper.PostMethod<User>(user, "/users/recover");
            ViewBag.Message = "parola yenileme linkiniz mailinize yollandı.";
            return View("./ForgotPassword");
        }
        [HttpGet("[controller]/recoverypassword/{token}/{userid}")]
        public IActionResult NewPassword(string token, int userid)
        {
            
            ViewBag.Token = token;
            ViewBag.UserId = userid;
            return View("./PasswordRecovery");
        }
        [HttpPost]
        public IActionResult SendNewPassword(string token, int userid, string password, string retrypassword)
        {
            if(password != retrypassword)
            {
                ViewBag.Danger = "Parolarınız eşleşmiyor";
                ViewBag.Token = token;
                ViewBag.UserId = userid;
                return View("./PasswordRecovery");
            }
            User user = new User();
            user.id = userid;
            user.activationToken = token;
            user.password = password;
            var c = _helper.PostMethod<User>(user, "/users/newpassword");
            ViewBag.Message="Parolanız başarıyla yenilendi";

            return View("./PasswordRecovery");
        }
        [HttpPost]
        public IActionResult AddUser(string username, string password, string email, string approve)
        {
            if(approve != "yes")
            {
                ViewBag.Danger = "Üye olmak için filmci sözlük kullanıcı sözleşmesini onaylamanız gerekmekte.";
                return View("../Login/Register");
            }
            User user = new User();
            user.username = username;
            var apiendpoint = $"/users/username/{username}";
            var usercontrol = _helper.GetApiEndpoint<User>(apiendpoint);
            if(usercontrol != null)
            {
                ViewBag.Danger = "Kullanıcı adı daha önce alınmış.";
                return View("../Login/Register");
            }
            user.password = password;
            user.email = email;
            apiendpoint = $"/users/email/{email}";
            usercontrol = _helper.GetApiEndpoint<User>(apiendpoint);
            if (usercontrol != null)
            {
                ViewBag.Danger = "Mail daha önce kullanılmış.";
                return View("../Login/Register");
            }
            _helper.PostMethod<User>(user, "/Users");
            ViewBag.Message = "Kaydınız başarıyla oluşturuldu! Hadi kolay gelsin. Giriş yapabilirsiniz.";
            return View("../Login/Register");
        }

    }
}