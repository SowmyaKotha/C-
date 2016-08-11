using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI4.Controllers
{
    public class StateController : ApiController
    {
        [HttpGet]
        public string State(string SignalX, string initialstateX, string initialstateY)
        {

            string nextstateY = "";

            if (initialstateX == "1" && initialstateY == "0" && SignalX == "0")
            {
                nextstateY = "You are in the same state (Y=0)";
            }
            else
            {
                if (initialstateX == "1" && initialstateY == "0" && SignalX == "1")
                {
                    nextstateY = "You are in Y=1 state";
                }

                else
                {
                    if (initialstateX == "1" && initialstateY == "1" && SignalX == "1")
                    {
                        nextstateY = "You are in same state (Y=1)";
                    }
                    else
                    {
                        if (initialstateX == "1" && initialstateY == "1" && SignalX == "0")
                        {
                            nextstateY = "You are in Y=0 state";
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






            return nextstateY;

        }



        [HttpGet]
        public string Get()
        {
            return "default";
        }
    }
}

