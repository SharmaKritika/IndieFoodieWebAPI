using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndieFoodieWebAPI.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        
        public List<MenuItem> MenuItems { get; set; }
    }
}