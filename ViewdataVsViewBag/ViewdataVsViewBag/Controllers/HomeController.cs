using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ViewdataVsViewBag.Controllers
{
    public class HomeController : Controller
    {
        GetPostEntities OE = new GetPostEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Read(int ID)
        {
            var Name = OE.tbl_MyTable.Where(p => p.ID == ID).FirstOrDefault().Name;
            var Age = OE.tbl_MyTable.Where(p => p.ID == ID).FirstOrDefault().Age;

            ViewData["N"] = Name;
            ViewData["A"] = Age;


            return View("Index");//getting back to index view after being redirected from index view to read
        }

       
    }
}