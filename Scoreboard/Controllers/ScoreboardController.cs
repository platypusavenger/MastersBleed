using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestSharp;
using System.IO;
using System.Text;
using System.Web;

namespace Scoreboard.Controllers
{
    public class ScoreboardController : ApiController
    {
        
        // GET api/<controller>
        [Route("api/Scoreboard/Masters/2014")]
        public IHttpActionResult GetMasters2014()
        {
            //string serviceUrl = "http://www.masters.com/";
            //string endpoint = "en_US/xml/gen/homeScores/homeScores.json";
            //RestClient client = new RestClient(serviceUrl);
            //RestRequest request = new RestRequest(endpoint, Method.GET);
            //request.AddHeader("Content-Type", "application/json");
            //request.RequestFormat = DataFormat.Json;

            //IRestResponse response = client.Execute(request);
            //return Ok(SimpleJson.DeserializeObject(response.Content));

            // Masters results are finalized, just return the results file saved off locally instead
            string path = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\Masters2014.json");
            string readContents;
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                readContents = streamReader.ReadToEnd();
            }
            return Ok(SimpleJson.DeserializeObject(readContents));
        }

        // GET api/<controller>
        [Route("api/Scoreboard/usopen/2014")]
        public IHttpActionResult GetUSOpen2014()
        {
            //string serviceUrl = "http://www.usopen.com/";
            //string endpoint = "en_US/xml/gen/homeScores/homeScores.json";
            //RestClient client = new RestClient(serviceUrl);
            //RestRequest request = new RestRequest(endpoint, Method.GET);
            //request.AddHeader("Content-Type", "application/json");
            //request.RequestFormat = DataFormat.Json;

            //IRestResponse response = client.Execute(request);

            //return Ok(SimpleJson.DeserializeObject(response.Content.Replace("<!-- SSI Error -->", "")));
            string path = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\USOpen2014.json");
            string readContents;
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                readContents = streamReader.ReadToEnd();
            }
            return Ok(SimpleJson.DeserializeObject(readContents));

        }

        // GET api/<controller>
        [Route("api/Scoreboard/britishopen/2014")]
        public IHttpActionResult GetBritishOpen2014()
        {
            //string serviceUrl = "http://www.theopen.com/";
            //string endpoint = "Feeds/TheOpen/Scoring/TraditionalViewFeed.aspx";
            //RestClient client = new RestClient(serviceUrl);
            //RestRequest request = new RestRequest(endpoint, Method.GET);
            //request.AddHeader("Content-Type", "application/json");
            //request.RequestFormat = DataFormat.Json;

            //IRestResponse response = client.Execute(request);

            //return Ok(SimpleJson.DeserializeObject(response.Content.Replace("<!-- SSI Error -->", "")));
            string path = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\BritishOpen2014.json");
            string readContents;
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                readContents = streamReader.ReadToEnd();
            }
            return Ok(SimpleJson.DeserializeObject(readContents));
        }

        // GET api/<controller>
        [Route("api/Scoreboard/pgachampionship/2014")]
        public IHttpActionResult GetPGAChampionship2014()
        {
            //string serviceUrl = "http://data.pga.com/";
            //string endpoint = "jsonp/event/pgachampionship/2014/leaderboard/json/leaderboard.json?callback=pga_leaderboardLoaded";
            //RestClient client = new RestClient(serviceUrl);
            //RestRequest request = new RestRequest(endpoint, Method.GET);
            //request.AddHeader("Content-Type", "application/json");
            //request.RequestFormat = DataFormat.Json;

            //IRestResponse response = client.Execute(request);
            //String content = response.Content.Replace("pga_leaderboardLoaded(", "");
            //content = content.Replace(");", "");
            //return Ok(SimpleJson.DeserializeObject(content));
            string path = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\PGAChampionship2014.json");
            string readContents;
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                readContents = streamReader.ReadToEnd();
            }
            return Ok(SimpleJson.DeserializeObject(readContents));
        }
    }
}