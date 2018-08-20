﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginVerification.Models;
using System.IO;
using System.Text;
using Domain;
using BusinessLogic;
using Database;
using System.Web.Security;

namespace LoginVerification.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        ILoginService loginService;
        public LoginController() {
            KutebaDatabase db = new KutebaDatabase();
            loginService = new LoginService(db);
        }

        [HttpGet]
        public ActionResult index(String ReturnUrl)
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
                    FormsAuthentication.SetAuthCookie(u.UserName, true);
                    return Redirect(Url.Action("index", "home"));// View("You have successfully logged in ", user);
                }
                else {
                    ModelState.AddModelError("", "Unknowen user name and passwrod combination");
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


        [HttpGet]
        public ActionResult signout()
        {
            FormsAuthentication.SignOut();
            return Redirect(Url.Action("index", "login"));
        }

    }
}