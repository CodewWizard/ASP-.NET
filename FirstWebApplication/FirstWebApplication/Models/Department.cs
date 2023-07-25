using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace FirstWebApplication.Models
{
    [Table("codewizard-Dept")]
    public class Department
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}