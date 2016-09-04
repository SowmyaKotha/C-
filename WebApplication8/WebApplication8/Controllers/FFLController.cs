using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication8.Controllers
{
    public class FFLController : ApiController
    {
        
        
        [EnableCors(origins: "*", headers: "*", methods: "GET")]
        [HttpGet]
        public IHttpActionResult State(int SignalX, int initialstateX, int Controlsign1,int SignalY,int Controlsign2,int Controlsign3)
        {
            
            var client1 = new RestClient("http://localhost:58536/");
            var request1 = new RestRequest("api/gene/state/" + SignalX + "/" + initialstateX + "/" + Controlsign1, Method.GET);
            
            IRestResponse response1 = client1.Execute(request1);
            string responseValue1 = response1.Content;
            var client2 = new RestClient("http://localhost:58536/");
            var request2 = new RestRequest("api/gene/state/" + SignalX + "/" + initialstateX + "/" + Controlsign2, Method.GET);
            IRestResponse response2 = client2.Execute(request2);
            string responseValue2 = response2.Content;
            int res2 = Convert.ToInt32(responseValue2);
            Boolean boolresponsevalue2 = Convert.ToBoolean(res2);
            string initialStateY = responseValue1;
            var client3 = new RestClient("http://localhost:58536/");
            var request3 = new RestRequest("api/gene/state/" + SignalY + "/" + initialStateY + "/" + Controlsign3, Method.GET);
            IRestResponse response3 = client3.Execute(request3);
            string responseValue3 = response3.Content;
            int res3 = Convert.ToInt32(responseValue3);
            Boolean boolresponsevalue3 = Convert.ToBoolean(res3);
            Boolean finalres = boolresponsevalue2 && boolresponsevalue3;
            int finalresponse = Convert.ToInt32(finalres);

            int[] finalresult = new int[2];
            finalresult[0] = res2;
            finalresult[1] = finalresponse;

            //finalresult[0] = 12;
            
            return Ok(finalresult);
        }

        
    }
}
