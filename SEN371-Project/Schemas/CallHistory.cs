using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class CallHistory
    {
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public int ClientPhoneNumber { get; set; }
        public string Location { get; set; }
        public string JobDescription { get; set; }

        public CallHistory(string clientName, string clientSurname, int clientPhoneNumber, string location, string jobDescription)
        {
            ClientName = clientName;
            ClientSurname = clientSurname;
            ClientPhoneNumber = clientPhoneNumber;
            Location = location;
            JobDescription = jobDescription;
        }
    }
}
