using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class staff
    {
        public staff()
        {

        }

        public int IdStaff { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Firdname { get; set; }
        public int IdDoljnost { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }


    }
}
