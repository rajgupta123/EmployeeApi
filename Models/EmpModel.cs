using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
{
    public class EmpModel
    {
        public int Id { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
