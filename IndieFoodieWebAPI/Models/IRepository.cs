using System.Collections.Generic;
using System.Linq;

namespace IndieFoodieWebAPI.Models
{
    public interface IRepository
    {
        IQueryable<Restaurant> GetRestaurants();
        IQueryable<MenuItem> GetMenuItems(int restaurantId);
    }
}