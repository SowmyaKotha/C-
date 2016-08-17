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
        public string FFLState(string Signal, string initialstateG1, string State)
        {

            string nextstateG2 = "";

            if (State=="Activation" && initialstateG1=="1" && Signal=="1")
            {
                nextstateG2 = "You are in G2 = 1 state";
            }
           else if(State == "Activation" && initialstateG1 == "1" && Signal == "0")
            {
                nextstateG2 = "You are in G2 = 0 state";
            }
            if(State == "Inhibition" && initialstateG1 == "1" && Signal == "0")
            {
                nextstateG2 = "You are in G2 = 1 state";
            }
            else if (State == "Inhibition" && initialstateG1 == "1" && Signal == "1")
            {
                nextstateG2 = "You are in G2 = 0 state";
            }
            else if (initialstateG1 == "0")
            {
                nextstateG2 = "Sorry! no transition";
            }






            return nextstateG2;

        }
     

        [HttpGet]
        public string Get()
        {
            return "default";
        }
    }
}












 