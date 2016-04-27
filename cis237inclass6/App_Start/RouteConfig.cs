using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cis237inclass6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Could use this route if you wanted to. It will work.
            //We just don't need it so I commented it out.

            //Most specific to most generic url
            //routes.MapRoute(
            //    name: "Foo",
            //    url: "Foo",
            //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            //);            
            
            //Most specific to most generic url
            //routes.MapRoute(
            //    name: "Foo",
            //    url: "{controller}/foo",
            //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            //);

            //Most specific to most generic url
            //routes.MapRoute(
            //    name: "Foo",
            //    url: "{controller}/Foo",
            //    defaults: new { controller = "Home", action = "Foo", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Json",
                url: "api/{controller}/Json",
                defaults: new { controller = "Car", action = "Json" }
            );
 
            //More generic url
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
