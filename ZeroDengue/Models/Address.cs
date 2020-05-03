using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroDengue.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string PublicPlace { get; set; }//Logradouro
        public string ZipCode { get; set; }//CEP
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Address()
        {

        }

        public Address(int addressId, string publicPlace, string zipCode, int number, string city, string state)
        {
            AddressId = addressId;
            PublicPlace = publicPlace;
            ZipCode = zipCode;
            Number = number;
            City = city;
            State = state;
        }
    }
}
