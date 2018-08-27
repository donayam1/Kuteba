using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kuteba.Controllers
{
    [Authorize]
    public class UserAdminController : Controller
    {
        [HttpPost]
        // GET: UserAdmin
        public ActionResult UpdatePending(String UserId,Boolean status)
        {
            
            return View();
        }
    }
}