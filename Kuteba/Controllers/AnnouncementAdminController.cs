using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kuteba.Controllers
{
    public class AnnouncementAdminController : Controller
    {
        // GET: AnnouncementAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List() {
            return View();
        }
        public ActionResult Edit() {
            return View();
        }

    }
}