using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class JobsProgresscs
    {
        string employeeName, employeeSurname, equipmentDetails, jobDescription;
        char location;
        int activeTime;
        bool onTime;

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeSurname { get => employeeSurname; set => employeeSurname = value; }
        public string EquipmentDetails { get => equipmentDetails; set => equipmentDetails = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public char Location { get => location; set => location = value; }
        public int ActiveTime { get => activeTime; set => activeTime = value; }
        public bool OnTime { get => onTime; set => onTime = value; }

        public JobsProgresscs(string employeeName, string employeeSurname, string equipmentDetails, string jobDescription, char location, int activeTime, bool onTime)
        {
            this.EmployeeName = employeeName;
            this.EmployeeSurname = employeeSurname;
            this.EquipmentDetails = equipmentDetails;
            this.JobDescription = jobDescription;
            this.Location = location;
            this.ActiveTime = activeTime;
            this.OnTime = onTime;
        }
    }
}
