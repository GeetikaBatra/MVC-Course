using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    //if we donot mention any controller,then by default home controller is accessed and method index is accessed .This is because in app_start 
    //in route map default controller is home and default action is index
    public class HomeController : Controller
    {
       public string Index()
        {
            return "Welcome to Mvc Series from home Index";
        }
    }
}