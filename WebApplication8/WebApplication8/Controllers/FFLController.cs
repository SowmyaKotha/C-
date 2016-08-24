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
        public IHttpActionResult State(string SignalX, string initialstateX, string Controlsign)
        {
            var client = new RestClient("http://genesc.azurewebsites.net/");
            var request = new RestRequest("api/gene/state/" + SignalX + "/" + initialstateX + "/" + Controlsign, Method.GET);

            IRestResponse response = client.Execute(request);
            string responseValue = response.Content;
            return Ok(responseValue);
        }
        
        
    }
}
