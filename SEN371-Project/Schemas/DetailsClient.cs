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
        public string ClientPhoneNumber { get; set; }
        public string ClientEmailAddress { get; set; }
        public string ClientAddress { get; set; }
        public string ClientCountry { get; set; }
        public string ClientZipCode { get; set; }

        public DetailsClient(string name, string surname, string phoneNumber, string emailAddress, string address, string country, string zipCode)
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
