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
            Console.Write("Enter Employee ID: ");
            string emloyeeId = Console.ReadLine();

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Middle Name (Press Enter to skip): ");
            string middleName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());
        
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
    }
}
