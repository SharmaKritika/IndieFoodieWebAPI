using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace IndieFoodieWebAPI.Controllers
{
    [EnableCors(origins: "http://indiefoodie.azurewebsites.net", headers: "*", methods: "*")]
    public class RestaurantController : ApiController
    {
        // Get: api/restaurant
        public HttpResponseMessage GetRestaurants()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(restaurants, Encoding.UTF8, "application/json");
            return response;
        }


        string restaurants = @"[
    {
        ""id"": 1,
        ""name"": ""Punjabi Curry WA"",
        ""postcode"": ""4300"",
        ""address"": ""123 Calm St, Springfield Lakes"",
        ""suburb"": ""springfield lakes""
    },
    {
        ""id"": 2,
        ""name"": ""Chinese Curry"",
        ""postcode"": ""4115"",
        ""address"": ""123 Calm St, Parkinson"",
        ""suburb"": ""parkinson""
    },
    {
        ""id"": 3,
        ""name"": ""Thai Curry"",
        ""postcode"": ""4078"",
        ""address"": ""123 Calm St, Forest Lake"",
        ""suburb"": ""forest lake""
    },
    {
        ""id"": 4,
        ""name"": ""French Curry"",
        ""postcode"": ""4018"",
        ""address"": ""123 Calm St, Fitzgibbon"",
        ""suburb"": ""fitzgibbon""
    },
    {
       ""id"": 5,
       ""name"": ""Italian Curry"",
       ""postcode"": ""4059"",
       ""address"": ""123 Calm St, Kelvin Grove"",
       ""suburb"": ""kelvin grove""
    },
    {
        ""id"": 6,
        ""name"": ""British Curry"",
        ""postcode"": ""4115"",
        ""address"": ""123 Calm St, Parkinson"",
        ""suburb"": ""parkinson""
    },
    {
        ""id"": 7,
        ""name"": ""Japanese Curry"",
        ""postcode"": ""4078"",
        ""address"": ""123 Calm St, Forest Lake"",
        ""suburb"": ""forest lake""
    },
    {   ""id"": 8,
        ""name"": ""American Curry"",
        ""postcode"": ""4078"",
        ""address"": ""123 Calm St, Forest Lake"",
        ""suburb"": ""forest lake""
    },
    {   ""id"": 9,
        ""name"": ""Vietnamese Curry"",
        ""postcode"": ""4018"",
        ""address"": ""123 Calm St, Fitzgibbon"",
        ""suburb"": ""fitzgibbon""
    },
    {   ""id"": 10,
        ""name"": ""Indonesian Curry"",
        ""postcode"": ""4078"",
        ""address"": ""123 Calm St, Forest Lake"",
        ""suburb"": ""forest lake""
    },
    {
        ""id"": 11,
        ""name"": ""Indian Curry"",
        ""postcode"": ""4300"",
        ""address"": ""123 Calm St, Springfield Lakes"",
        ""suburb"": ""springfield lakes""
    }
    
]";
    }
}
