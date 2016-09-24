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
        public IHttpActionResult State(int SignalX1, int initialstateX1, int Controlsign1, int SignalY1, int Controlsign2, int Controlsign3, int Controlsign4, int Controlsign5, int SignalX2, int SignalY2, int Controlsign6, int Controlsign7, int Controlsign8, int Controlsign9, int Controlsign10)
        {
            var client1 = new RestClient("http://genestatecharts.azurewebsites.net/");
            var request1 = new RestRequest("api/ffl/state/" + SignalX1 + "/" + initialstateX1 + "/" + Controlsign1 + "/" + SignalY1 + "/" + Controlsign2 + "/" + Controlsign3, Method.GET);
            IRestResponse response1 = client1.Execute(request1);
            string responseValue1 = response1.Content;
            char first = responseValue1[1]; // X1-->Z1
            int nextZ1 = Convert.ToInt32(first.ToString());
            char second = responseValue1[3]; //X1-->Y1-->Z1
            int nextnextZ1 = Convert.ToInt32(second.ToString());
            var client2 = new RestClient("http://genestatecharts.azurewebsites.net/");
            var request2 = new RestRequest("api/ffl/state/" + SignalX1 + "/" + initialstateX1 + "/" + Controlsign1 + "/" + SignalY1 + "/" + Controlsign4 + "/" + Controlsign5, Method.GET);
            IRestResponse response2 = client2.Execute(request2);
            string responseValue2 = response2.Content;
            char initialX = responseValue2[3];  // next next X2
            string initialStateX2 = second.ToString();
            var client3 = new RestClient("http://genestatecharts.azurewebsites.net/");
            var request3 = new RestRequest("api/ffl/state/" + SignalX2 + "/" + initialStateX2 + "/" + Controlsign6 + "/" + SignalY2 + "/" + Controlsign7 + "/" + Controlsign8, Method.GET);
            IRestResponse response3 = client3.Execute(request3);
            string responseValue3 = response3.Content;
            char third = responseValue3[1];// X2-->Z2
            int nextZ2 = Convert.ToInt32(third.ToString());
            char fourth = responseValue3[3];//X2-->Y2-->Z2
            int nextnextZ2 = Convert.ToInt32(fourth.ToString());
            var client4 = new RestClient("http://genestatecharts.azurewebsites.net/");
            var request4 = new RestRequest("api/ffl/state/" + SignalX2 + "/" + initialStateX2 + "/" + Controlsign6 + "/" + SignalY2 + "/" + Controlsign9 + "/" + Controlsign10, Method.GET);
            IRestResponse response4 = client4.Execute(request4);
            string responseValue4 = response4.Content;
            char fifth = responseValue4[1];// X2-->Z3
            int nextZ3 = Convert.ToInt32(fifth.ToString());
            char sixth = responseValue4[3];//X2-->Y2-->Z3
            int nextnextZ3 = Convert.ToInt32(sixth.ToString());

            int[] finalresult = new int[6];
            finalresult[0] = nextZ1;
            finalresult[1] = nextnextZ1;
            finalresult[2] = nextZ2;
            finalresult[3] = nextnextZ2;
            finalresult[4] = nextZ3;
            finalresult[5] = nextnextZ3;

            return Ok(finalresult);
        }
    }
}
