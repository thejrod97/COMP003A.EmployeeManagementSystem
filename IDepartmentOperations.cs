using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
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
