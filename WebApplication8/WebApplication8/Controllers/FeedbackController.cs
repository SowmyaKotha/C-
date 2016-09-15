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
    public class FeedbackController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "GET")]
        [HttpGet]
        public IHttpActionResult State(int SignalX, int initialstateX, int Controlsign1,int SignalY,int initialstateY,int Controlsign2)
        {
            var client1 = new RestClient("http://localhost:58536/");
            var request1 = new RestRequest("api/gene/state/" + SignalX + "/" + initialstateX + "/" + Controlsign1, Method.GET);
            IRestResponse response1 = client1.Execute(request1);
            string responseValue1 = response1.Content;
            int nextstateY = Convert.ToInt32(responseValue1);
            var client2 = new RestClient("http://localhost:58536/");
            var request2 = new RestRequest("api/gene/state/" + SignalY + "/" + initialstateY + "/" + Controlsign2, Method.GET);
            IRestResponse response2 = client2.Execute(request2);
            string responseValue2 = response2.Content;
            int nextstateX = Convert.ToInt32(responseValue2);
            int[] finalresult = new int[2];
            finalresult[0] =nextstateY ;
            finalresult[1] = nextstateX;
            return Ok(finalresult);
        }
    }
}
