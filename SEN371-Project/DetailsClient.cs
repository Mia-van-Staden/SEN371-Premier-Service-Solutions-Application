using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class DetailsClient
    {
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public int ClientPhoneNumber { get; set; }
        public char ClientEmailAddress { get; set; }
        public char ClientAddress { get; set; }
        public string ClientCountry { get; set; }
        public int ClientZipCode { get; set; }

        public DetailsClient(string name, string surname, int phoneNumber, char emailAddress, char address, string country, int zipCode)
        {
            ClientName = name;
            ClientSurname = surname;
            ClientPhoneNumber = phoneNumber;
            ClientEmailAddress = emailAddress;
            ClientAddress = address;
            ClientCountry = country;
            ClientZipCode = zipCode;
        }
    }
}
