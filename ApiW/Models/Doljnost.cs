using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class Doljnost
    {
        public Doljnost()
        {

        }

        public int IdDoljnost { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public bool Deleted { get; set; }

    }
}
