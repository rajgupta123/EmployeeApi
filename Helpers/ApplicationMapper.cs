using AutoMapper;
using EmployeeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<EmpDBModel, EmpModel>().ReverseMap();
        }
    }
}
