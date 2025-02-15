using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// Employee class contains all of the fields, properties, constructor, and methods that all revolve around storing Employee data.
    /// I didn't use try catch validation, instead I just used If statements with ArgumentExceptions for all the inputs.
    /// </summary>
    class Employee
    {
        // Fields
        private string _employeeId;
        private string _firstName;
        private string _middleName = "";
        private string _lastName;
        private double _salary;

        /// <summary>
        /// After the first input, EmployeeID property can only be read.
        /// </summary>
        public string EmployeeID
        {
            get { return _employeeId; }
        }

        /// <summary>
        /// FirstName property reads and allows for modification. There is validation put in place for unwanted null and white space.
        /// </summary>
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

        /// <summary>
        /// MiddleName property reads and allows for modification. There is validation put in place for an unwanted null but empty values are allowed.
        /// </summary>
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

        /// <summary>
        /// LastName property reads and allows for modification. There is validation put in place for unwanted null and white space.
        /// </summary>
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

        /// <summary>
        /// Salary property reads and allows for modification. There is validation put in place for any integer values that are less than 0.
        /// </summary>
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

        /// <summary>
        /// This method displays the employee's first, middle, and last.
        /// </summary>
        public void PrintFullName()
        {
            if (string.IsNullOrWhiteSpace(MiddleName))
            {
                Console.WriteLine($"Name: {FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"Name: {FirstName} {MiddleName} {LastName}");
            }
        }

        /// <summary>
        /// This method displays the employee's information.
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            PrintFullName();
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
}
