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

            int nextstate = 2;
            int b = Convert.ToInt32(sign());

            if (initialstateX == 1 && Controlsign == 1 && Signal == 0)
            {
                nextstate = 0;
            }
            else
            {
                if (initialstateX == 1 && Controlsign == 1 && Signal == 1)
                {
                    nextstate = 1;
                }

                else
                {
                    if (initialstateX == 1 && Controlsign == 0 && Signal == 1)
                    {
                        nextstate = 0;
                    }
                    else
                    {
                        if (initialstateX == 1 && Controlsign == 0 && Signal ==0)
                        {
                            nextstate =1;
                        }
                        else
                        {
                            if (initialstateX == 0)
                            {
                                nextstate = -1;
                            }
                        }
                    }
                }
            }



        int R1 = nextstate;

            return Ok(R1);

        }
       public static int sign()
        {
           int A = 14;
            return A;
        }
    }
}
