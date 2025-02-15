using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    class Employee
    {
        // Fields
        private string _employeeId;
        private string _firstName;
        private string _middleName = "";
        private string _lastName;
        private double _salary;

        // Properties
        public string EmployeeID
        {
            get { return _employeeId; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name can't be null or have white space.");
                _firstName = value;
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Middle name can't be null");
                _middleName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name can't be null or have white space.");
                _lastName = value;
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary can't be less than 0");
                _salary = value;
            }
        }

        // Constructor!
        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;
        }

        // Method
        public void PrintFullName()
        {
            if (string.IsNullOrWhiteSpace(MiddleName))
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
            }
        }

        // Method
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary}");
        }
    }
}
