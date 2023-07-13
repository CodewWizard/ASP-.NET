using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    [Table("tblEmployee")]
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Emps { get; set; }
    }
}