using System;
using EmployeeManagement.Entities;
using EmployeeManagement.BusinessLogicLayer;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.PresentationLayer
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee Management System");
            int choice = 1, j;
            while (choice == 1)
            {
                Console.WriteLine("Choose Which CRUD Operation you want to perform:\n1.Insert\n2.Read\n3.Update\n4.Delete");
                j = int.Parse(Console.ReadLine());
                Employee employee = new Employee();
                EmployeeBusinessLogicLayer employeeBusineessLogicLayer = new EmployeeBusinessLogicLayer();
                switch (j)
                {
                    case 1:
                        Console.WriteLine(employeeBusineessLogicLayer.AddEmployee(employee));
                        break;
                     case 2:
                        employeeBusineessLogicLayer.ReadEmployee(employee);
                        break;
                    case 3:

                        Console.WriteLine(employeeBusineessLogicLayer.UpdateEmployee(employee.EmployeeId, employee.EmployeeSalary));
                        
                        break;
                    case 4:

                        Console.WriteLine(employeeBusineessLogicLayer.DeleteEmployee(employee.EmployeeId));
                        
                        break;

                }
            }

        }
    }
}