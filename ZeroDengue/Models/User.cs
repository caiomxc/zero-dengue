using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroDengue.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ssn { get; set; } //CPF
        public string PhoneNumber { get; set; }
        public int Address { get; set; }
    }
}
