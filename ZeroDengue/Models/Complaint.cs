using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroDengue.Models.Enums;

namespace ZeroDengue.Models
{
    public class Complaint
    {
        public int ComplaintId { get; set; }
        public int ComplaintNumber { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public StatusComplaint Status { get; set; }
        public User User { get; set; }

        public Complaint()
        {

        }

        public Complaint(int complaintId, int complaintNumber, string picture, string description, Address address, StatusComplaint status, User user)
        {
            ComplaintId = complaintId;
            ComplaintNumber = complaintNumber;
            Picture = picture;
            Description = description;
            Address = address;
            Status = status;
            User = user;
        }
    }
}
