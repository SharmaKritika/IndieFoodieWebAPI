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
using IndieFoodieWebAPI.Models;
using System.Web.Http.Description;

namespace IndieFoodieWebAPI.Controllers
{
    [EnableCors(origins: "http://indiefoodie.azurewebsites.net", headers: "*", methods: "*")]
    [ExceptionHandling]
    //[EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class RestaurantsController : ApiController
    {
        private IRepository repo;

        public RestaurantsController(IRepository repo)
        {
            this.repo = repo;
        }

        // Get: api/restaurants
        public IQueryable<Restaurant> GetRestaurants()
        {
            return repo.GetRestaurants();
        }

        // Get: api/restaurants/{restaurantId}/menuItems
        public IQueryable<MenuItem> GetMenuItems(int restaurantId)
        {
            return repo.GetMenuItems(restaurantId);
        }
    }
}
