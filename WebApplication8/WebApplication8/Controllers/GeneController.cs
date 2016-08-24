using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication8.Controllers
{
    public class GeneController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "GET")]
        [HttpGet]
        public IHttpActionResult State(string SignalX, string initialstateX, string Controlsign)
        {

            string nextstateY = "";

            if (initialstateX == "1" && Controlsign == "Activiation" && SignalX == "0")
            {
                nextstateY = "You are in the same state (Y=0)";
            }
            else
            {
                if (initialstateX == "1" && Controlsign == "Activiation" && SignalX == "1")
                {
                    nextstateY = "You are in Y=1 state";
                }

                else
                {
                    if (initialstateX == "1" && Controlsign == "Inhibition" && SignalX == "1")
                    {
                        nextstateY = "You are in same state (Y=0)";
                    }
                    else
                    {
                        if (initialstateX == "1" && Controlsign == "Inhibition" && SignalX == "0")
                        {
                            nextstateY = "You are in Y=1 state";
                        }
                        else
                        {
                            if (initialstateX == "0")
                            {
                                nextstateY = "Sorry! Can't make a transition!";
                            }
                        }
                    }
                }
            }






            return Ok(nextstateY);

        }
    }
}
