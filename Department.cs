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
}
