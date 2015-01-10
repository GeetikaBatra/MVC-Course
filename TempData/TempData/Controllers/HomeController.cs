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
            //if (TempData["msg"] != null)
            //{
            //    string m = TempData["msg"].ToString();
            //    ViewBag.M = m;
            //}
           
            return View();
        }
        public ActionResult Insert(FormCollection f)
        {
            string msg;
            try
            {
                DepartmentEntities OE = new DepartmentEntities();
                tbl_Department D = new tbl_Department();
                D.D_Name = f["DName"].ToString();
                D.HOD = f["HOD"].ToString();
                OE.tbl_Department.Add(D);
                OE.SaveChanges();
                
                msg="Record is Inserted";
            }
            catch
            {
                msg = "Record not inserted";
            }
            TempData["msg"] = msg;
            TempData.Keep();//or  TempData.Keep("msg") for a particular msg to be kept in temp data
            return RedirectToAction("Index");
           
        }

        public ActionResult Test()
        {
            if (TempData["msg"]!= null)
            {
                string m = TempData["msg"].ToString();
                ViewBag.M = m;
            }

            return View();
        }

      
    }
}