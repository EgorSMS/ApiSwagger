using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class OrderList
    {
        public OrderList()
        {
           
        }

        public int IdOrderList { get; set; }
        public int Count { get; set; }
        public int IdProduct { get; set; }
        public bool Deleted { get; set; }


    }
}
