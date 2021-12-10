using System;
using System.Collections.Generic;

#nullable disable

namespace ApiW.Models
{
    public partial class Client
    {
        public Client()
        {
            
        }

        public int IdClient { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Firdname { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
    }
}
