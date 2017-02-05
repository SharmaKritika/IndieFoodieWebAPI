using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndieFoodieWebAPI.Models
{
    public class Repository : IRepository
    {
        private IndieFoodieWebAPIContext db;

        public Repository(IndieFoodieWebAPIContext db)
        {
            this.db = db;
        }

        public IQueryable<Restaurant> GetRestaurants()
        {
            return db.Restaurants;
        }

        public IQueryable<MenuItem> GetMenuItems(int restaurantId)
        {
            return db.MenuItems.Where(m => m.RestaurantId == restaurantId);
        }
    }
}