using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Database;
using BusinessLogic;

namespace Kuteba.Controllers
{
    [Authorize]
    public class UserAdminController : Controller
    {
        KutebaDatabase kdb;
        IUpdatePendingService pendingServices;
        public UserAdminController() {
            kdb = new KutebaDatabase();
            pendingServices = new UpdatePendingService(kdb);
        }
        [HttpPost]
        // GET: UserAdmin
        public ActionResult UpdatePending(string UserId,bool status)
        {
            pendingServices.pendingController(UserId, status);
            kdb.SaveChanges();
            return View();
        }
    }
}