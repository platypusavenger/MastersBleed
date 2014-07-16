using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Scoreboard.Controllers
{
    /// <summary>
    /// Helper class tucked into the Scoreboard App to provide quick test end-points for prototyping in other applications.
    /// </summary>
    public class SampleController : ApiController
    {
        [HttpGet]
        [Route("api/Sample/Amplify/GetLoginForCohort/{token}/{gameId}")]
        public IHttpActionResult GetSampleAmplifyData(string token, string gameId)
        {
            string json = "{ \"id\": \"" + gameId + "\", \"server\": \"184.73.59.188\", \"key\": \"12345\", \"zone\": \"Zone05\", \"zonePassword\": \"Egregious Raccoon\" }";
            return Ok(SimpleJson.DeserializeObject(json));
        }

        [HttpPost]
        [Route("api/Sample/Amplify/RegisterZone")]
        public IHttpActionResult RegisterZone(AmplifyServerDetails details)
        {
            return Ok(details);
        }

        [HttpPost]
        [Route("api/Sample/Amplify/UnregisterZone")]
        public IHttpActionResult UnregisterZone(AmplifyServerDetails details)
        {
            return Ok(details);
        }

        [HttpGet]
        [Route("api/Sample/Amplify/GetZonePassword/{ip}/{zoneId}")]
        public String GetZonePassword(string ip, string zoneId)
        {
            return "Egregious Raccoon";
        }

        [HttpPost]
        [Route("api/Sample/Amplify/DeallocateZone")]
        public IHttpActionResult DeallocateZone(AmplifyServerDetails details){
            return Ok(details);
        }

    }

    public class AmplifyServerDetails
    {
        public string server { get; set; }
        public string zone { get; set; }
        public string zonePassword { get; set; }
        public int gameId { get; set; }
    }

}
