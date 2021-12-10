using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class TypeOfPaying
    {
        public TypeOfPaying()
        {

        }

        public int IdTypeOfPay { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

    }
}
