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
            config.EnableSystemDiagnosticsTracing();
            var cors = new EnableCorsAttribute("*", "*", "GET");
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
            name: "ActionApi",
            routeTemplate: "api/{controller}/{action}/{Signal}/{initialstateX}/{Controlsign}"
        );

            config.Routes.MapHttpRoute(
       name: "FeedbackApi",
       routeTemplate: "api/{Feedback}/{feedback_state}/{SignalX}/{initialstateX}/{Controlsign1}/{SignalY}/{initialstateY}/{Controlsign2}",
        defaults: new { controller = "Feedback", action = "feedback_state" }
);
            config.Routes.MapHttpRoute(
name: "FFLApi",
routeTemplate: "api/{FFL}/{State}/{SignalX}/{initialstateX}/{Controlsign1}/{SignalY}/{Controlsign2}/{Controlsign3}",
defaults: new { controller = "FFL", action = "State" }
);


            config.Routes.MapHttpRoute(
             name: "SecondApi",
             routeTemplate: "api/{controller}/{action}/{SignalX1}/{initialstateX1}/{Controlsign1}/{SignalY1}/{Controlsign2}/{Controlsign3}/{Controlsign4}/{Controlsign5}/{SignalX2}/{SignalY2}/{Controlsign6}/{Controlsign7}/{Controlsign8}/{Controlsign9}/{Controlsign10}"
         );
  







        }
    }
}
