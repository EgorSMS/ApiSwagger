using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class Order
    {
        public int IdOrder { get; set; }
        public decimal OrderCost { get; set; }
        public int IdOrderList { get; set; }
        public int IdRestaurant { get; set; }
        public int IdStaff { get; set; }
        public int IdClient { get; set; }
        public int IdTypeOfPay { get; set; }
        public int IdTypeofDeliver { get; set; }
        public bool Deleted { get; set; }


    }
}
