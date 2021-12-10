using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class Product
    {
        public Product()
        {

        }

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public bool Deleted { get; set; }

    }
}
