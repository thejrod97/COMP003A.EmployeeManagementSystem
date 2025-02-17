// Author: Justin Rodriguez 
// Course: COMP-003A
// Faculty: Jonathan Cruz 
// Purpose: Employee management system demonstrating OOP principles in C#
namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// This is the main class for the program and it encompasses all of the other classes from the other files.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry point for the program and contains prompts to ask the user for Employee information so it can save the data and display it.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // Added exception handling for parsing salary, employee constructor, first name, last name, and salary.
            try
            {
                Console.Write("Enter Employee ID: ");
                string emloyeeId = Console.ReadLine();

                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(firstName))
                    throw new ArgumentException("First name can't be null or have white space.");

                Console.Write("Enter Middle Name (Press Enter to skip): ");
                string middleName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(lastName))
                    throw new ArgumentException("Last name can't be null or have white space.");

                Console.Write("Enter Salary: ");
                double salary;
                if (!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
                throw new ArgumentException("Invalid salary input or salary is less than 0");

                Employee employee1 = new Employee(emloyeeId, firstName, middleName, lastName, salary);

                Console.WriteLine("\nEmployee Created Successfully!\n");
                employee1.DisplayEmployeeInfo();

                HRDepartment HumanResources = new HRDepartment { DepartmentName = "Human Resources" };
                ITDepartment InformationTech = new ITDepartment { DepartmentName = "IT" };

                Console.Write("\n");
                HumanResources.DisplayDepartmentInfo();
                Console.WriteLine($"Details: {HumanResources.GetDepartmentDetails()}");
                HumanResources.Operate();

                Console.Write("\n");
                InformationTech.DisplayDepartmentInfo();
                Console.WriteLine($"Details: {InformationTech.GetDepartmentDetails()}");
                InformationTech.Operate();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Input error.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured.");
            }
            
        }
    }
}
