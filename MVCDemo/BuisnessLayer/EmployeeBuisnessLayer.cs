using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BuisnessLayer
{
    public class EmployeeBuisnessLayer
    {
        public IEnumerable<EmployeeB> Employees
        {
            get
            {
                string connectionString = "data source=.; database=codewizard-Employee; integrated security=SSPI";
                List<EmployeeB> employees = new List<EmployeeB>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        EmployeeB employee = new EmployeeB();
                        employee.EmpId = Convert.ToInt32(rdr["EmpId"]);
                        employee.EmpName = rdr["EmpName"].ToString();
                        employee.EmpGender = rdr["EmpGender"].ToString();
                        employee.EmpCity = rdr["EmpCity"].ToString();
                        employee.DepartmentID = Convert.ToInt32(rdr["DepartmentID"]);

                        employees.Add(employee);
                    }
                }

                return employees;       
             }
        }
    }
}
