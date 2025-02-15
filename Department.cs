using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// Department class is a parent class and contains with it derived classes and an interface.
    /// The purpose of this is to organize data from different departments better.
    /// </summary>
    public abstract class Department
    {
        /// <summary>
        /// DepartmenName auto-implemented property to store data from departments with different names.
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// This abstract method is used for derived classes so they can modify it to their needs.
        /// </summary>
        /// <returns></returns>
        public abstract string GetDepartmentDetails();

        /// <summary>
        /// This concrete method is used to display the departments name.
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }
    }

    /// <summary>
    /// Derived class used for the purpose of using methods from the parent class and property.
    /// </summary>
    public class HRDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// This is the abstract method being used from the Department parent class.
        /// </summary>
        /// <returns></returns>
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }

        /// <summary>
        /// A method from the Interface class being used in this derived class so it can display the departments operations.
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performs operations that relate to employee-realted issues, recruitment, compensation, training, compliance, etc.");
        }
    }

    /// <summary>
    /// Derived class used for the purpose of using methods from the parent class and property.
    /// </summary>
    public class ITDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// This is the abstract method being used from the Department parent class.
        /// </summary>
        /// <returns></returns>
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure";
        }

        /// <summary>
        /// A method from the Interface class being used in this derived class so it can display the departments operations.
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performs operations that relate to administration, support, networking, projects, software development, etc.");
        }
    }

    /// <summary>
    /// Interface class used for the purpose of assigning a contract to other classes that use it.
    /// </summary>
    public interface IDepartmentOperations
    {
        /// <summary>
        /// This Operate method is going to be used for other classes so they can modify the details inside of it to explain their departmnents operations.
        /// </summary>
        void Operate();
    }
}
