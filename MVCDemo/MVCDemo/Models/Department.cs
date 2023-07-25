using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("codewizard-Department")]
    public class Department
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string number { get; set; }
        public List<Employee> Employees { get; set; }
    }
}