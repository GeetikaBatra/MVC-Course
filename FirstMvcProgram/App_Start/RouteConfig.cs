using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstMvcProgram
{
    public class RouteConfig

    {
        // users donot type urls on the site name,by simplifying url we get benefit i.e SEO(search engine optimization)
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//to ignore some files,eg if we dont want user to have access to xml files or config files 
            //the command .axd can be replaced by xml or whatever files extension is,this will ignore all the files with this extension

            
            routes.MapRoute(
               name: "Home",
               url: "Home",
               defaults: new { controller = "Home", action = "GotoHomePage", id = UrlParameter.Optional }//if anyone writes jst home,it goes to home controller and invoke gotohome
                
           );
            routes.MapRoute(
               name: "Home1",
               url: "Home/Home",
               defaults: new { controller = "Home", action = "GotoHomePage", id = UrlParameter.Optional }//if anyone writes jst home,it goes to home controller and invoke gotohome

           );
            routes.MapRoute(
               name: "Home2",
               url: "",//even if the user writes nothing still the page takes it to the home page
               defaults: new { controller = "Home", action = "GotoHomePage", id = UrlParameter.Optional }//if anyone writes jst home,it goes to home controller and invoke gotohome

           );
            //Never make the following code at start because i will be parsed and all other routekeys will be bypassed
            routes.MapRoute(/* * route.MapRoute(here route is a type of route collection and Maproute has 3 important things 1st is the key name which is default by default*/
                name: "Default",
                url: "{controller}/{action}/{id}",//this tells that if the url is in the format i.e controllername/action name/value,then go and invoke the action="index" inside it
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //adding one more route here
            );

        }
    }
}
