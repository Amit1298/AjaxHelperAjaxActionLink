using AjaxHelperAjaxActionLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxHelperAjaxActionLink.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllEmployees()
        {
            var data = db.employees.ToList();
            return PartialView("_Employees",data);
        }
    }
}