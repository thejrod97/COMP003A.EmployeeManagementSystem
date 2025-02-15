using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    public abstract class Department
    {
        public string DepartmentName { get; set; }

        public abstract string GetDepartmentDetails();

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }
    }

    public class HRDepartment : Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }

        public void Operate()
        {
            Console.WriteLine("Performs operations that relate to employee-realted issues, recruitment, compensation/benefits, training, compliance, etc.");
        }
    }

    public class ITDepartment : Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure";
        }

        public void Operate()
        {
            Console.WriteLine("Performs operations that relate to administration, support, networking, projects, software development, etc.");
        }
    }

    public interface IDepartmentOperations
    {
        void Operate();
    }
}
