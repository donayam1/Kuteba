using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database;
using BusinessLogic;
using ViewModels;
using Domain;

namespace Kuteba.Controllers
{
    public class AnnouncementAdminController : Controller
    {
        IAnnouncementService iaes;
        public AnnouncementAdminController()
        {
            KutebaDatabase kdb = new KutebaDatabase();
            iaes = new AnnouncementService(kdb);
        }
        // GET: AnnouncementAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(AnnouncementViewModel avm)
        {
            if (ModelState.IsValid)
            {
                Announcemnets ans = iaes.EditNewAnnouncement(avm);
                return Redirect(Url.Action("Edit", "Index"));
            }
            else
            {
                ModelState.AddModelError("", "Incomplete form. Please try again.");
                return View();
            }
        }

    }
}