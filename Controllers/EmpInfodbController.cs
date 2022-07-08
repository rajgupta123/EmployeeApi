using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Repository;
using AutoMapper;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpInfodbController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;
     

        public EmpInfodbController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
           
        }
        [HttpGet]
        [Route("DisplayAll")]
        public async Task<IActionResult> GetAllEmp()
        {
            var ar = await employeeRepo.GetAllEmployeeAsync();
            return Ok(ar);
        }
        [HttpPost]
        [Route("Insert")]
        public async Task<IActionResult> InsertEmployee( EmpModel  empModel )
        {
            var ar = await employeeRepo.AddEmployee(empModel);
            return Ok(ar);
        }
        [HttpPut]
        [Route("UpdateEmp/{id?}")]
        public async Task<IActionResult> UpdateEmployee(int? id,EmpModel empModel)
        {
            if (id != null)
            {
                await employeeRepo.UpdateEmployeeAsync(id, empModel);
                return Ok();
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("DeleteEmp/{id?}")]
        public async Task<IActionResult> DeleteEmployee(int? id)
        {
            if (id != null)
            {
                await employeeRepo.DeleteEmployeeAsync(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
