using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidartionExample.Models;

namespace ValidartionExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Create(User U)
        {
           if(ModelState.IsValid)
           { return View(); }
           else
           {
               return View("Index");
           }
        }
    }
}