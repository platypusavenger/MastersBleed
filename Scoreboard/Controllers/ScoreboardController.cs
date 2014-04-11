using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestSharp;

namespace Scoreboard.Controllers
{
    public class ScoreboardController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            string serviceUrl = "http://www.masters.com/";
            string endpoint = "en_US/xml/gen/homeScores/homeScores.json";
            RestClient client = new RestClient(serviceUrl);
            RestRequest request = new RestRequest(endpoint, Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            
            IRestResponse response = client.Execute(request);
            return Ok(SimpleJson.DeserializeObject(response.Content));
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}