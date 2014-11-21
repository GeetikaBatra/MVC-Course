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
       //public string Index()
       // {
       //     return "Welcome to Mvc Series from home Index";
       // }
        //if we want Mvc to be a hyperlink ang home Index to be bold then
        //public string Index()
        //{
        //    return "Welcome to<a href='http://www.Yahoo.com'> Mvc </a> from <b>Home-Index</b>";
        //    now we wanna make the above string in multi line,instead of return we use a string result with @
        //    so that we could see it here in small space,but in browser it would show as single line,here we jst want to 
        //    limit our screen view
        //    string result=@"Welcome to<a href='http://www.Yahoo.com'> Mvc </a> from <b>Home-Index</b>";
        //    string result = @"<form> <table> </tr> <tr> <td > <label for='first_name'>First Name *</label> </td> <td valign='top'> <input  type='text' name='first_name' maxlength='50' size='30'></td></tr><tr><td valign='top'><label for=last_name'>Last Name *</label></td><td valign='top'><input  type='text' name='last_name' maxlength='50' size='30'></td></tr><tr><td valign='top'><label for='email'>Email Address *</label></td><td valign='top'><input  type='text' name='email' maxlength='80' size='30'></td></tr><tr><td valign='top'><label for='telephone'>Telephone Number</label></td><td valign='top'><input  type='text' name='telephone' maxlength='30' size='30'></td></tr><tr><td valign='top'><label for='comments'>Comments *</label></td><td valign='top'><textarea  name='comments' maxlength='1000' cols='25' rows='6'></textarea></td></tr><tr><td colspan='2' style='text-align:center'><input type='submit' value='Submit'></td></tr></form>";
        //   above code is unmanageable so instead of returning a string we return a viewresult file which is used for such html views file.
        
        //    return result;

        //}
        public ViewResult Index()//right click on index and click addview to add an html file
        {
            return View();
        }
        
    }
}