using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class JobLog
    {
        string clientName, clientSurname, equipmentDetails, jobDescription, clientAddress, location, startDate, endDate, clientphoneNumber, clientZipCode;
        int expectedTime;
        

        public JobLog(string clientName, string clientSurname, string equipmentDetails, string jobDescription, string clientphoneNumber, string clientZipCode, int expectedTime, string clientAddress, string location, string startDate, string endDate)
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
        public string ClientphoneNumber { get => clientphoneNumber; set => clientphoneNumber = value; }
        public string ClientZipCode { get => clientZipCode; set => clientZipCode = value; }
        public int ExpectedTime { get => expectedTime; set => expectedTime = value; }
        public string ClientAddress { get => clientAddress; set => clientAddress = value; }
        public string Location { get => location; set => location = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
    }
}
