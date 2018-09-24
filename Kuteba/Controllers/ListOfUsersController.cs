using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database;
using Domain;
using BusinessLogic;

namespace Kuteba.Controllers
{
    public class ListOfUsersController : Controller
    {
        IListUserService listUsers;
        public ListOfUsersController() {

            KutebaDatabase db = new KutebaDatabase();
            listUsers = new ListUserService(db);
        }
        // GET: ListOfUsers
        public ActionResult ListUsers()
        {
            return View(listUsers.ListUsers());
        }
    }
}