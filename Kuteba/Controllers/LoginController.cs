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
using Database;
using System.Web.Security;
using ViewModels;

namespace LoginVerification.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        ILoginService loginService;
        ISignupService signupService;
        public LoginController() {
            KutebaDatabase db = new KutebaDatabase();
            loginService = new LoginService(db);
            signupService = new SignupService(db);
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
        public ActionResult SignUp() {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserSignUpViewModel usr)
        {
            if (ModelState.IsValid)
            {
                User u = signupService.Signup(usr);
                return Redirect(Url.Action("index", "home"));
            }
            else
            {
                ModelState.AddModelError("", "Already registered user or invalid data entry. Try again.");
                return View("");
            }
        }


        [HttpGet]
        public ActionResult signout()
        {
            FormsAuthentication.SignOut();
            return Redirect(Url.Action("index", "login"));
        }

    }
}