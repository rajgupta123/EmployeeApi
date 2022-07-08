using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
{
    public class EmpDBModel
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }
}
