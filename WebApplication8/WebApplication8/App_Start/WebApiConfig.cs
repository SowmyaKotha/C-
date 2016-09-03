using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication8
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var cors = new EnableCorsAttribute("*", "*", "GET");
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
              name: "ActionApi1",
              routeTemplate: "api/{controller}/{action}/{SignalX1}/{initialstateX}/{Controlsign1}/{SignalY1}/{Controlsign2}/{Controlsign3}/{SignalX2}/{SignalY2}/{Controlsign4}/{Controlsign5}/{Controlsign6}/{Controlsign7}/{Controlsign8}/{Controlsign9}/{Controlsign10}"
          );
            config.Routes.MapHttpRoute(
              name: "ActionApi",
              routeTemplate: "api/{controller}/{action}/{SignalX}/{initialstateX}/{Controlsign1}/{SignalY}/{Controlsign2}/{Controlsign3}"
          );

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{action}/{Signal}/{initialstateX}/{Controlsign}"
           );
        }
    }
}
