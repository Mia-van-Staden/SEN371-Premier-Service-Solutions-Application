using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class PerformanceRating
    {
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string JobDescription { get; set; }
        public DateTime EndDate { get; set; }
        public int Performancerating { get; set; }

        public PerformanceRating(string name, string surname, string jobDescription, DateTime endDate, int performanceRating)
        {
            EmployeeName = name;
            EmployeeSurname = surname;
            JobDescription = jobDescription;
            EndDate = endDate;
            Performancerating = performanceRating;
        }
    }
}
