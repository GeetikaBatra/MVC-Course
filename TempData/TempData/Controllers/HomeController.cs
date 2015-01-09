using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Insert(FormCollection f)
        {

            DepartmentEntities OE = new DepartmentEntities();
            tbl_Department D = new tbl_Department();
            D.D_Name = f["DName"].ToString();
            D.HOD = f["HOD"].ToString();
            OE.tbl_Department.Add(D);
            OE.SaveChanges();
            return RedirectToAction("Index");
        }

      
    }
}