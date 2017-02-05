using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndieFoodieWebAPI.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        
        public Restaurant Restaurant { get; set; }
    }

}
