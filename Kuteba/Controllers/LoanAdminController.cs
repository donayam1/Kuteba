using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kuteba.Controllers
{
    public class LoanAdminController : Controller
    {
        // GET: LoanAdmin
        public ActionResult CreateLoan()
        {
            return View();
        }

        public ActionResult ListEmployeeLoan(String EmployeeId)
        {
            return View();
        }
    }
}