using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class HistoryJob
    {
        string clientName, clientSurname, jobDescription, EmployeeName, EmployeeSurname;
        int clientPhoneNumber, performanceRating;
        char location;
        DateTime endDate;

        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientSurname { get => clientSurname; set => clientSurname = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public string EmployeeSurname1 { get => EmployeeSurname; set => EmployeeSurname = value; }
        public int ClientPhoneNumber { get => clientPhoneNumber; set => clientPhoneNumber = value; }
        public int PerformanceRating { get => performanceRating; set => performanceRating = value; }
        public char Location { get => location; set => location = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        public HistoryJob(string clientName, string clientSurname, string jobDescription, string employeeName, string employeeSurname, int clientPhoneNumber, int performanceRating, char location, DateTime endDate)
        {
            this.clientName = clientName;
            this.clientSurname = clientSurname;
            this.jobDescription = jobDescription;
            EmployeeName = employeeName;
            EmployeeSurname = employeeSurname;
            this.clientPhoneNumber = clientPhoneNumber;
            this.performanceRating = performanceRating;
            this.location = location;
            this.endDate = endDate;
        }
    }
}
