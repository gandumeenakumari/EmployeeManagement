using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.DataAccessLayer;
using EmployeeManagement.Entities;

namespace EmployeeManagement.BusinessLogicLayer
{
    public class EmployeeBusinessLogicLayer
    {

        public Employee AddEmployee(Employee employee)
            {
                EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            
            Console.WriteLine("Enter Employee Id");
            employee.EmployeeId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            employee.EmployeeName=Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            employee.EmployeeDept = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            employee.EmployeeSalary = Console.ReadLine();
                return employeeDataAccessLayer.AddEmployee(employee);
            }
        public Employee UpdateEmployee(int EmployeeId,string EmployeeSalary)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            Console.WriteLine("Enter Employee Id whose info You want to update");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Salary you want to update");
            EmployeeSalary = Console.ReadLine();
            return employeeDataAccessLayer.UpdateEmployee(EmployeeId,EmployeeSalary);
        }
        public Employee ReadEmployee(Employee employee)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            return employeeDataAccessLayer.ReadEmployee(employee);
        }
        public Employee DeleteEmployee(int EmployeeId)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            Console.WriteLine("Enter Employee Id whose info You want to Delete");
            EmployeeId = int.Parse(Console.ReadLine());
            return employeeDataAccessLayer.DeleteEmployee(EmployeeId);
        }
        public Employee GetEmployee(int EmployeeId)
        { 
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            return employeeDataAccessLayer.GetEmployee(EmployeeId);
            
        }

    }
}
