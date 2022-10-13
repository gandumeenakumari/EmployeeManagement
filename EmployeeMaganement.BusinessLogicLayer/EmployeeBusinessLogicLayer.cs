using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.DataAccessLayer;
using EmployeeManagement.Entities;

namespace EmployeeManagement.BusinessLogicLayer
{
    public class EmployeeBusinessLogicLayer
    {
        public int AddEmployee(Employee employee)
        {
        EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
        return EmployeeDataAccessLayer.AddEmployee(employee);
        }

    }
}
