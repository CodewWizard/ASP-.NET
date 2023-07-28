using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Employee1
    {
        [Required]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string EmpCity { get; set; }
        [Required]
        public string EmpGender { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}
