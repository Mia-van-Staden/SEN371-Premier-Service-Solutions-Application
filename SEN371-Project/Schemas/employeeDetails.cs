using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class employeeDetails
    {
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeeZipCode { get; set; }

        public employeeDetails(string name, string surname, string phoneNumber, string email, string address, string country, string zipCode)
        {
            EmployeeName = name;
            EmployeeSurname = surname;
            EmployeePhoneNumber = phoneNumber;
            EmployeeEmail = email;
            EmployeeAddress = address;
            EmployeeCountry = country;
            EmployeeZipCode = zipCode;
        }
    }
}
