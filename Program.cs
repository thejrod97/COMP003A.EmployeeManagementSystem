// Author: Justin Rodriguez 
// Course: COMP-003A
// Faculty: Jonathan Cruz 
// Purpose: Employee management system demonstrating OOP principles in C#
namespace COMP003A.EmployeeManagementSystem
{
    public static class Program
    {
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

            double salary;
            while (true)
            {
                Console.Write("Enter Salary: ");
                if (double.TryParse(Console.ReadLine(), out salary) && salary >=0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter an amount that is greater than or equal to 0.");
                }
            }

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
