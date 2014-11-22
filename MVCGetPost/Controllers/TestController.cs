using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGetPost.Controllers
{ //WHENEVER we hit this action method,we have values in it
    //how do we read the values in this method,there are 3 ways to do that
    //1st -have the data passed as parameters to your action method.
    //Extract it from a set of context objects.
    //explicitly invoke the framework's model binding feature.
    public class TestController : Controller
    {
        // GET: Test
        //parameters method 
        public ActionResult GotoThisAction(string N_Name,int N_Age)
           
        {
            return View();
        }
    }
}