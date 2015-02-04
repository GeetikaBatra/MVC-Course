using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidartionExample.Models;
//Following is a server side validation
//For client side validation we need to add 3 javascript files
namespace ValidartionExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            GetQualificationInViewBag();
            return View();
        }

        private void GetQualificationInViewBag()
        {
            List<SelectListItem> Items = new List<SelectListItem>();
            Items.Add(new SelectListItem { Text = "", Value = "", Selected = true });
            Items.Add(new SelectListItem { Text = "B.Tech", Value = "0" });
            Items.Add(new SelectListItem { Text = "M.Tech", Value = "1" });
            Items.Add(new SelectListItem { Text = "MCA", Value = "2" });
            Items.Add(new SelectListItem { Text = "Ph.D", Value = "3" });

            ViewBag.Qualifications = Items;
        }
       [HttpPost]
        public ActionResult Create(User U)
        {
            GetQualificationInViewBag();
           if(ModelState.IsValid)
           { return View(); }
           else
           {
               return View("Index");
           }
        }
    }
}