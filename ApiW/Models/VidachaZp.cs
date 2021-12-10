using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class VidachaZp
    {
        public int IdDoc { get; set; }
        public string Status { get; set; }
        public int IdPerson { get; set; }
        public DateTime Date { get; set; }
        public bool Deleted { get; set; }

    }
}
