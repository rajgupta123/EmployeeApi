using EmployeeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repository
{
public    interface IEmployeeRepo
    {
        Task<List<EmpModel>> GetAllEmployeeAsync();
        Task<EmpModel> GetEmpByIdAsync(int id);
        Task<int> AddEmployee(EmpModel empDBModel);
        Task DeleteEmployeeAsync(int? id);
        Task UpdateEmployeeAsync(int? id, EmpModel empDBModel);
        
    }
}
