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
        public Address Address { get; set; }
        public ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();

        public User()
        {

        }

        public User(int userId, string name, string email, string password, string ssn, string phoneNumber, Address address)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Password = password;
            Ssn = ssn;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public void AddComplaint(Complaint complaint)
        {
            Complaints.Add(complaint);
        }

        public void RemoveComplaint(Complaint complaint)
        {
            Complaints.Remove(complaint);
        }
    }
}
