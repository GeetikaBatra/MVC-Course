using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    //This is we defininig a controller named department,but on browser if we dont mention the name department,then it
    //looks for a default controller,this default controller is the home controller which is a new controller to be added in the controller section
    //in the solution explorer.
    //though we can change it i.e make department controller as default controller and get info method as default action
    //Just go to app_start file and replace default controller from home to department and default action from index to getinfo.

    //Introduction to Controller
    public class DepartmentController : Controller//departmentcontroller is a class derived from class controller already in it,it contains methods
    {
        // GET: Department
        //But for this to work we have to cooment out above index which is of type action result,otherwise the browser address will get confused 
        //which one to run
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string GetInfo()//controller means a class and action means method
        {
            return "Welcome ToString my FirstApplication MVC view";
        }
        public string GetInfoWithDate()
        {
            return "Welcome to my first MVC program " + DateTime.Now.ToString();
        }
        public string index()//This is bydefault action i.e if we donot mention the action in a webpage this method will execute defaultly.
        {
            return "Welcome";
        }
    }
}