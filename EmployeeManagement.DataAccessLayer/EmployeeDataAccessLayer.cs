using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using EmployeeManagement.Entities;
using Azure.Core;

namespace EmployeeManagement.DataAccessLayer
{
    public class EmployeeDataAccessLayer
    {
        
        string ConnectionString = @"Data Source=DESKTOP-N5NGH7K\SQLEXPRESS;Initial Catalog=EmployeeManagement;Integrated Security=True;
                           Encrypt=True;TrustServerCertificate=True;User Instance=False";
        SqlConnection sqlConnection;

        
        public string AddEmployee(Employee employee)
        {
            string status;
            try
            {
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string insetQuery = "insert into Employee(EmployeeId,EmployeeName,EmployeeDept,EmployeeSalary) values(" + employee.EmployeeId + ",'" + employee.EmployeeName + "','" + employee.EmployeeDept + "','" + employee.EmployeeSalary + "')";
                SqlCommand cmd = new SqlCommand(insetQuery, sqlConnection);
                cmd.ExecuteNonQuery();
                status = "Data Inserted Successfully";

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                status = "Data cannot be Inserted";
            }
            return status;

        }
        public string  UpdateEmployee(int EmployeeId,string EmployeeSalary)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string updateQuery = "update Employee set EmployeeSalary=" + EmployeeSalary + "where EmployeeId=" + EmployeeId + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            

            Employee updateEmployee = new Employee();
            string status = "Updated The Data";
            return status ;
        }
        public string ReadEmployee(Employee employee)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string displayQuery = "select *from Employee";
            SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataReader dataReader = displayCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("Emp id:" + dataReader.GetValue(0).ToString());
                Console.WriteLine("Emp name:"+dataReader.GetValue(1).ToString());
                Console.WriteLine("Emp dept:"+dataReader.GetValue(2).ToString());
                Console.WriteLine("Emp sal:"+dataReader.GetValue(3).ToString());
                Console.WriteLine("----");
            }
            dataReader.Close();
            string status= "Read Completed";
            return status;
        

        }
        public string DeleteEmployee(int EmployeeId)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string deleteQuery = "Delete from Employee where EmployeeId=" + EmployeeId;
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Employee deleteEmployee = new Employee();
            string status="Deleted Successfully";
            return status;
        }

        public Employee GetEmployee(int EmployeeId)
        {
            Employee employee = null;
            return employee;
        }
    }
}
