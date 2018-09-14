using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using Database;
using ViewModels;

namespace Kuteba.Controllers
{
    public class AddEmployeeController : Controller
    {
        KutebaDatabase db;
        EmployeeManager em;

        public AddEmployeeController()
        {
             db = new KutebaDatabase();
             em = new EmployeeManager(db);
        }

        // GET: Add
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Search(String ID)
        {
            var VM = em.ViewEmployee(ID);
            return Json(VM);
        }

        [HttpPost]
        public ActionResult Index(EmployeeViewmodel evm)
        {

            //gets all the Files uploaded to the viewmodel and compiles them into a File collection
           HttpFileCollection HFC =  System.Web.HttpContext.Current.Request.Files;

            //converts The Releative Path into an Absolute path on The Server hosting The website
            string path = System.Web.Hosting.HostingEnvironment.MapPath("/Contents/Upload");

            //for each of the files uploaded to The viewmodel, loop assigns A random name, add's it to the path and Generates a location
             foreach (HttpPostedFile v in HFC)
            {
                Guid newName = Guid.NewGuid();//Guid Type generates Random Name "newName"
                string FileLocation = System.IO.Path.Combine(path, newName.ToString());//combines Random name and path into a completed location
                
                v.SaveAs(FileLocation);
                System.IO.FileInfo ff = new System.IO.FileInfo(FileLocation);
            }
            em.AddEmployee(evm);
            return View();
        }
    }
}