using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class OtdelKadrov
    {
        public OtdelKadrov()
        {
        }

        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FirdName { get; set; }
        public int Snils { get; set; }
        public int Inn { get; set; }
        public string Gender { get; set; }
        public int SeriaPas { get; set; }
        public int NumberPas { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int IdDoljnost { get; set; }
        public bool Deleted { get; set; }


    }
}
