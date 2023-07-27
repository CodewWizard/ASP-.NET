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
        public IEnumerable<Employee1> Employees
        {
            get
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

                List<Employee1> employees = new List<Employee1>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee1 employee = new Employee1();
                        employee.EmpId = Convert.ToInt32(rdr["EmpId"]);
                        employee.EmpName = rdr["EmpName"].ToString();
                        employee.EmpCity = rdr["EmpCity"].ToString();
                        employee.EmpGender = rdr["EmpGender"].ToString();
                        employee.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);

                        employees.Add(employee);
                    }
                }

                return employees;
            }
        }

        public void AddEmployee(Employee1 employee)
        {
            string connectionString =
            ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@EmpId";
                paramId.Value = employee.EmpId;
                cmd.Parameters.Add(paramId);

                SqlParameter paramName = new SqlParameter();
                paramName.ParameterName = "@EmpName";
                paramName.Value = employee.EmpName;
                cmd.Parameters.Add(paramName);

                SqlParameter paramCity = new SqlParameter();
                paramCity.ParameterName = "@EmpCity";
                paramCity.Value = employee.EmpCity;
                cmd.Parameters.Add(paramCity);

                SqlParameter paramGender = new SqlParameter();
                paramGender.ParameterName = "@EmpGender";
                paramGender.Value = employee.EmpGender;
                cmd.Parameters.Add(paramGender);


                SqlParameter paramDepartmentId = new SqlParameter();
                paramDepartmentId.ParameterName = "@DepartmentId";
                paramDepartmentId.Value = employee.DepartmentId;
                cmd.Parameters.Add(paramDepartmentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}