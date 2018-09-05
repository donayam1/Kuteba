﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using Database;

namespace Kuteba.Controllers
{
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        // GET: Announcement
        IAnnouncementService ListAnn;
        KutebaDatabase KDb = new KutebaDatabase();

        AnnouncementController()
        {
            ListAnn = new AnnouncementService(KDb);
        }
        public ActionResult Index()
        {

            return View(ListAnn.ListAnnouncements());
        }
    }
}