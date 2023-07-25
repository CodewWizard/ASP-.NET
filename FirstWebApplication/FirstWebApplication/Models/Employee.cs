using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApplication.Models
{
    [Table("codewizard-Employee")]
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public string EmpGender { get; set; }
        public int DepartmentID { get; set; }
    }
}