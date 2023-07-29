using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class JobLog
    {
        string clientName, clientSurname, equipmentDetails, jobDescription;
        int clientphoneNumber, clientZipCode, expectedTime;
        char clientAddress, location;
        DateTime startDate, endDate;

        public JobLog(string clientName, string clientSurname, string equipmentDetails, string jobDescription, int clientphoneNumber, int clientZipCode, int expectedTime, char clientAddress, char location, DateTime startDate, DateTime endDate)
        {
            this.ClientName = clientName;
            this.ClientSurname = clientSurname;
            this.EquipmentDetails = equipmentDetails;
            this.JobDescription = jobDescription;
            this.ClientphoneNumber = clientphoneNumber;
            this.ClientZipCode = clientZipCode;
            this.ExpectedTime = expectedTime;
            this.ClientAddress = clientAddress;
            this.Location = location;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientSurname { get => clientSurname; set => clientSurname = value; }
        public string EquipmentDetails { get => equipmentDetails; set => equipmentDetails = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public int ClientphoneNumber { get => clientphoneNumber; set => clientphoneNumber = value; }
        public int ClientZipCode { get => clientZipCode; set => clientZipCode = value; }
        public int ExpectedTime { get => expectedTime; set => expectedTime = value; }
        public char ClientAddress { get => clientAddress; set => clientAddress = value; }
        public char Location { get => location; set => location = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
