using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpInfoController : ControllerBase
    {
      static  List<Employee> lstemp = new List<Employee>()
        {
            new Employee{Id=101,EmpName="Raj kumar",Salary=9995000},
              new Employee{Id=1011,EmpName="abhay Raj",Salary=9994000},
                new Employee{Id=1031,EmpName="Jone",Salary=9993000},
                  new Employee{Id=1022,EmpName="Ram",Salary=929000}
        };
        [HttpGet("showall")]
        public ActionResult<List<Employee>>GetAllEmp()
        {
            return lstemp;
        }
        [HttpGet("search/{id?}")]
        public ActionResult<Employee> Search(int? id)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            return ar;
        }
        //https://localhost:44335/api/EmpInfo/search1/101
       // [Route("search1/{id?}")]
        [HttpGet("search1/{id?}")]
        public ActionResult<Employee> Search1(int? id)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            return ar;
        }
        [HttpPost]
        public ActionResult<List<Employee>> Insert(Employee employee)
        {
            lstemp.Add(employee);
            return lstemp;
        }
        [HttpDelete]
        public int  Delete(int id)
        {
            var ar= lstemp.FirstOrDefault(x => x.Id == id);
            if(ar!=null)
            {
                lstemp.Remove(ar);
            }
           
            return 1;
        }
        [HttpPut("{id}")]
        public int Put(int id,Employee employee)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            if (ar != null)
            {
                ar.EmpName = employee.EmpName;
                ar.Salary = employee.Salary;
               // lstemp.Remove(ar);
            }

            return 1;
        }
    }
}






