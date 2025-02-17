﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
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
}
