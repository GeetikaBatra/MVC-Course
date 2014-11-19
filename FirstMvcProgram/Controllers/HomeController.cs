using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcProgram.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GotoHomePage()
        {
            return View("MyHomePage");
        }
    }/*Lab 2 routing-Routing simplifies MVC URL
  * Routing simplifies your URl struucture like Home/Home/GotoHome ..>/Home
      * goto sol exp
      * goto app_start
      * goto routing config
      * there is a route collection 
      * routing is nothing but a collection which maps the user friendly url with controller and method name
      
      
      
      */

}