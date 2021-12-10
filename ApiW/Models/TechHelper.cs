using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class TechHelper
    {
        public int IdTecHelp { get; set; }
        public string Request { get; set; }
        public int IdClient { get; set; }
        public int IdStaff { get; set; }
        public bool Deleted { get; set; }


    }
}
