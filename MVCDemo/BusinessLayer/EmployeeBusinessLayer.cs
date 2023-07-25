using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employees
        {
            get
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

                List<Employee> employees = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.EmpId = Convert.ToInt32(rdr["Id"]);
                        employee.EmpName = rdr["Name"].ToString();
                        employee.EmpGender = rdr["Gender"].ToString();
                        employee.EmpCity = rdr["City"].ToString();
                        employee.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);

                        employees.Add(employee);
                    }
                }

                return employees;
            }
        }
    }
}