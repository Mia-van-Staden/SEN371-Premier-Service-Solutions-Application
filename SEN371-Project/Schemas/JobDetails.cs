using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class JobDetails
    {
        string equipmentDetails, jobDescription,location, startDate, endDate ;
        int possibleSlack, expectedTime;

        public JobDetails(string equipmentDetails, string jobDescription, string location, string startDate, string endDate, int expectedTime, int possibleSlack)
        {
            this.equipmentDetails = equipmentDetails;
            this.jobDescription = jobDescription;
            this.location = location;
            this.startDate = startDate;
            this.endDate = endDate;
            this.expectedTime = expectedTime;
            this.possibleSlack = possibleSlack;
        }

        public int PossibleSlack { get => PossibleSlack1; set => PossibleSlack1 = value; }
        public string EquipmentDetails { get => equipmentDetails; set => equipmentDetails = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public string Location { get => location; set => location = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public int ExpectedTime { get => expectedTime; set => expectedTime = value; }
        public int PossibleSlack1 { get => possibleSlack; set => possibleSlack = value; }
    }
}
