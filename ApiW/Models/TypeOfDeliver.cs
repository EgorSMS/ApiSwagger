using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class TypeOfDeliver
    {
        public TypeOfDeliver()
        {

        }

        public int IdTypeofDeliver { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

    }
}
