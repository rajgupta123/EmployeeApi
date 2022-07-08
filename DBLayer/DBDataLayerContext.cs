using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.DBLayer
{
    public class DBDataLayerContext:DbContext
    {
        public DBDataLayerContext(DbContextOptions<DBDataLayerContext>options):base(options)
        {

        }
     public   DbSet<EmpDBModel> Employees { get; set; }

    }
}
