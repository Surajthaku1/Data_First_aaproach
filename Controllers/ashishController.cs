using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_First_aaproach.Controllers
{
    public class ashishController : Controller
    {
        ADOPPEntities obj = new ADOPPEntities();
        // GET: ashish
        public ActionResult Index()
        {
            List<Employee> employees = obj.Employees.ToList();
            return View(employees);
        }
    }
}