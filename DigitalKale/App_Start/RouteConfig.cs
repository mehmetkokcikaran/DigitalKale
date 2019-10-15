using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DigitalKale
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "About",
              url: "Hakkimizda",
              defaults: new { controller = "About", action = "Index"}
          );

            routes.MapRoute(
            name: "Blog",
            url: "Blog",
            defaults: new { controller = "Blog", action = "Index" }
        );
            routes.MapRoute(
           name: "BlogDetail",
           url: "BlogDetail",
           defaults: new { controller = "Blog", action = "BlogDetail" }
       );

            routes.MapRoute(
          name: "Contact",
          url: "İletişim",
          defaults: new { controller = "Contact", action = "Index" }
      );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
