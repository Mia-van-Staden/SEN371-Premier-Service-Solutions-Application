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
        public int EmployeePhoneNumber { get; set; }
        public char EmployeeEmail { get; set; }
        public char EmployeeAddress { get; set; }
        public string EmployeeCountry { get; set; }
        public int EmployeeZipCode { get; set; }

        public employeeDetails(string name, string surname, int phoneNumber, char email, char address, string country, int zipCode)
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
