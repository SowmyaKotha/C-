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
            
            var client1 = new RestClient("http://genestatecharts.azurewebsites.net/");    //calling client using RestClient
            var request1 = new RestRequest("api/gene/state/" + SignalX + "/" + initialstateX + "/" + Controlsign1, Method.GET);  //requesting get method from gene controller with three parameters          
            IRestResponse response1 = client1.Execute(request1);    //executing the request from the client
            string responseValue1 = response1.Content;      // storing the content value in string for (X-->Y)
            var client2 = new RestClient("http://genestatecharts.azurewebsites.net/");     //calling client using RestClient
            var request2 = new RestRequest("api/gene/state/" + SignalX + "/" + initialstateX + "/" + Controlsign2, Method.GET);  //requesting get method from gene controller with three parameters
            IRestResponse response2 = client2.Execute(request2);    //executing the request from the client
            string responseValue2 = response2.Content;  // storing the content value in string for (X-->Z)
            int res2 = Convert.ToInt32(responseValue2);
            Boolean boolresponsevalue2 = Convert.ToBoolean(res2);
            string initialStateY = responseValue1;      // storing the initialstate of Y from the output of first client call which outputs next state Y
            var client3 = new RestClient("http://genestatecharts.azurewebsites.net/");
            var request3 = new RestRequest("api/gene/state/" + SignalY + "/" + initialStateY + "/" + Controlsign3, Method.GET);
            IRestResponse response3 = client3.Execute(request3);
            string responseValue3 = response3.Content;      // storing the content value in string for (Y-->Z)
            int res3 = Convert.ToInt32(responseValue3);
            Boolean boolresponsevalue3 = Convert.ToBoolean(res3);
            Boolean finalres = boolresponsevalue2 && boolresponsevalue3;
            int finalresponse = Convert.ToInt32(finalres);

            int[] finalresult = new int[2];
            finalresult[0] = res2;      // displaying the next state of Z
            finalresult[1] = finalresponse; // displaying the next next of Z            
            return Ok(finalresult);
        }

        
    }
}
