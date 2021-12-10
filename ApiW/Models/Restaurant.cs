using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            
        }

        public int IdRestaurant { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Deleted { get; set; }

    }
}
