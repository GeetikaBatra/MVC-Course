using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGetPost.Controllers
{
    public class HomeController : Controller
    {//Create a view by right clicking Index and click add View
        //once the form appears and we enter the details,on clicking submit it again hits the index method agin and again,
        public ActionResult Index()
        {
            return View();
        }
        //this will still not hit the following method,for that we will goto our html form and add an attribute action to form tag
        //Also the following wont show anything until we add a view to it
        public ActionResult MyActionSubmit()
        {
            return View();
        }

       

       
    }
}