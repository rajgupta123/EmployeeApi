using AutoMapper;
using EmployeeApi.DBLayer;
using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DBDataLayerContext dBDataLayerContext;
        private readonly IMapper mapper;

        public EmployeeRepo(DBDataLayerContext dBDataLayerContext,IMapper mapper)
        {
            this.dBDataLayerContext = dBDataLayerContext;
            this.mapper = mapper;
        }
        public async  Task<int> AddEmployee(EmpModel  empModel)
        {
            var ar = mapper.Map<EmpDBModel>(empModel);
      dBDataLayerContext.Employees.Add(ar);
           await dBDataLayerContext.SaveChangesAsync();
            return  1;
        }

        public async Task DeleteEmployeeAsync(int? id)
        {

            var ar = await dBDataLayerContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if(ar!=null)
            {
                dBDataLayerContext.Employees.Remove(ar);
            }
          await  dBDataLayerContext.SaveChangesAsync();
        }

        public async Task<List<EmpModel>> GetAllEmployeeAsync()
        {
           // var data 

            var data= await dBDataLayerContext.Employees.ToListAsync();
            var w = mapper.Map<List<EmpModel>>(data);

            return w;
        }

        public async Task<EmpModel> GetEmpByIdAsync(int id)
        {
            var ar = await dBDataLayerContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            var w = mapper.Map<EmpModel>(ar);
            return w;

        }

        public async Task UpdateEmployeeAsync(int? id, EmpModel empDBModel)
        {
            var ar = await dBDataLayerContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if(ar!=null)
            {
                ar.EmpName = empDBModel.EmpName;
                ar.Salary = empDBModel.Salary;
             await   dBDataLayerContext.SaveChangesAsync();
            }


        }
    }
}
