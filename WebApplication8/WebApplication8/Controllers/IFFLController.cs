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
    public class IFFLController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "GET")]
        [HttpGet]
        public IHttpActionResult State(int SignalX1, int initialstateX, int Controlsign1, int SignalY1, int Controlsign2, int Controlsign3,int SignalX2,int SignalY2,int Controlsign4,int Controlsign5,int Controlsign6,int  Controlsign7,int Controlsign8,int Controlsign9,int Controlsign10)
        {
            var client1 = new RestClient("http://genesc.azurewebsites.net/");
            var request1 = new RestRequest("api/ffl/state/" + SignalX1 + "/" + initialstateX + "/" + Controlsign1 +"/"+SignalY1 +"/"+Controlsign2+"/"+Controlsign3, Method.GET);
            IRestResponse response1 = client1.Execute(request1);
            string responseValue1 = response1.Content;
            var client2 = new RestClient("http://genesc.azurewebsites.net/");
            var request2 = new RestRequest("api/ffl/state/" + SignalX1 + "/" + initialstateX + "/" + Controlsign1 + "/" + SignalY1 + "/" + Controlsign4 + "/" + Controlsign5, Method.GET);
            IRestResponse response2 = client2.Execute(request2);
            string responseValue2 = response2.Content;
            string initialStateX2 = responseValue2;
            //int res2 = Convert.ToInt32(responseValue2);
            var client3 = new RestClient("http://genesc.azurewebsites.net/");
            var request3 = new RestRequest("api/ffl/state/" + SignalX2 + "/" + initialStateX2 + "/" + Controlsign6+ "/" + SignalY2 + "/" + Controlsign7 + "/" + Controlsign8, Method.GET);
            IRestResponse response3 = client3.Execute(request3);
            string responseValue3 = response3.Content;
            var client4 = new RestClient("http://genesc.azurewebsites.net/");
            var request4 = new RestRequest("api/ffl/state/" + SignalX2 + "/" + initialStateX2 + "/" + Controlsign6 + "/" + SignalY2 + "/" + Controlsign9 + "/" + Controlsign10, Method.GET);
            IRestResponse response4 = client4.Execute(request4);
            string responseValue4 = response4.Content;
            int res4 = Convert.ToInt32(responseValue4);
            return Ok(res4);
        }
    }
}
