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
        public IHttpActionResult State(int Signal, int initialstateX, int Controlsign)
        {

            int nextstate = -1; //initializing the nextstate variable to some value

            if (Controlsign == 1) // if controlsign is 1 then it is Activation
            {
                if (initialstateX == 1) // initial state X =1
                {
                    if (Signal == 0)    // Signal value is 0
                    {
                        nextstate = 0; // then next state Y will be 0
                    }
                    else if (Signal == 1) // Signal value is 1
                    {
                        nextstate = 1;  //then next state Y will be 1
                    }
                }
                else if (initialstateX == 0) // if initial state X =0
                {
                    nextstate = 0;  // then there is no transition
                }
            }
            else if (Controlsign == 0)  // if controlsign is 0 then it is Inhibition
            {
                if (initialstateX == 1)  // initial state X =1
                {
                    if (Signal == 0)     // Signal value is 0
                    {
                        nextstate = 1;  // then next state Y will be 1
                    }
                    else if (Signal == 1)   // Signal value is 1
                    {
                        nextstate = 0;  // then next state Y will be 0
                    }
                }
                else if (initialstateX == 0)    // if initial state X =0
                {
                    nextstate = 0;       // then there is no transition
                }
            }

            return Ok(nextstate);

        }

    }
}
