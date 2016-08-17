using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI2.Controllers
{
    public class StateController : ApiController
    {
        [HttpGet]
        public string FFLState(string SignalX, string initialstateX, string SignalY, string initialstateY, string initialstateZ)
        {

            string nextstateZ = "";

            if (initialstateX == "1" && initialstateY == "0" && SignalX == "0" && SignalY == "0" && initialstateZ == "0")
            {
                nextstateZ = "You are in the same 100 state";
            }
            else
            {
                if (initialstateX == "1" && initialstateY == "0" && SignalX == "0" && SignalY == "1" && initialstateZ == "0")
                {
                    nextstateZ = "You are in the same 100 state";
                }

                else
                {
                    if (initialstateX == "1" && initialstateY == "0" && SignalX == "1" && (SignalY == "0"|| SignalY=="1") && initialstateZ == "0")
                    {
                        nextstateZ = "You are in 110 state";

                    }
                   
                    else
                    {
                        if (initialstateX == "1" && initialstateY == "0" && SignalX == "0" && (SignalY == "0" || SignalY == "1") && initialstateZ == "1")
                        {
                            nextstateZ = "You are in 100 state";
                        }
                        else
                        {
                            if (initialstateX == "1" && initialstateY == "1" && SignalX == "0" && SignalY == "0"  && initialstateZ == "0")
                            {
                                nextstateZ = "You are in 100 state";
                            }
                            else
                            {
                                if (initialstateX == "1" && initialstateY == "1" && SignalX == "0" && SignalY == "1" && initialstateZ == "0")
                                {
                                    nextstateZ = "You are in 101 state";
                                }
                                else
                                {
                                    if (initialstateX == "1" && initialstateY == "1" && SignalX == "1" && SignalY == "0" && initialstateZ == "0")
                                    {
                                        nextstateZ = "You are in 110 state";
                                    }
                                    else
                                    {
                                        if (initialstateX == "1" && initialstateY == "1" && SignalX == "1" && SignalY == "1" && initialstateZ == "0")
                                        {
                                            nextstateZ = "You are in 111 state";
                                        }
                                        else
                                        {
                                            if (initialstateX == "1" && initialstateY == "1" && SignalX == "0" && SignalY == "0" && initialstateZ == "1")
                                            {
                                                nextstateZ = "You are in 100 state";
                                            }
                                            else
                                            {
                                                if (initialstateX == "1" && initialstateY == "1" && SignalX == "0" && SignalY == "1" && initialstateZ == "1")
                                                {
                                                    nextstateZ = "You are in 101 state";
                                                }
                                                else
                                                {
                                                    if (initialstateX == "1" && initialstateY == "1" && SignalX == "1" && SignalY == "0" && initialstateZ == "1")
                                                    {
                                                        nextstateZ = "You are in 110 state";
                                                    }
                                                    else
                                                    {
                                                        if (initialstateX == "1" && initialstateY == "1" && SignalX == "1" && SignalY == "1" && initialstateZ == "1")
                                                        {
                                                            nextstateZ = "You are in 111 state";
                                                        }
                                                        else
                                                        {
                                                            if (initialstateX == "0")
                                                            {
                                                                nextstateZ = "You are in 000 state";
                                                            }
                                                            if (initialstateX == "1" && initialstateY == "0" && SignalX == "1" && (SignalY == "0" || SignalY == "1") && initialstateZ == "1")
                                                            {
                                                                nextstateZ = "You are in 110 state";

                                                            }
                                                        }
                                                       
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }

            }






            return nextstateZ;

        }
     

        [HttpGet]
        public string Get()
        {
            return "default";
        }
    }
}












 