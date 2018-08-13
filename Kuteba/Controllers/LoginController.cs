using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginVerification.Models;
using System.IO;
using System.Text;
using Domain;
using BusinessLogic;
using Databse;

namespace LoginVerification.Controllers
{
    public class LoginController : Controller
    {
        ILoginService loginService;
        public LoginController() {
            KutebaDatabase db = new KutebaDatabase();
            loginService = new LoginService(db);
        }

        [HttpGet]
        public ActionResult index()
        {
            return View();
        }


        [HttpPost]        
        public ActionResult index(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                User u = new User()
                {
                    UserName = user.Username,
                    Password = user.Password
                };
                bool res = loginService.SignIn(u);
                if (res)
                {
                    //Cookie forms authentication
                    return Redirect("~/home/index");// View("You have successfully logged in ", user);
                }
                else {
                    return View("");
                }
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        
           
    }
}