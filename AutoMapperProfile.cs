using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using contractor_management.DTOs.Contractor.Request;
using contractor_management.DTOs.Contractor.Response;
using contractor_management.Models;

namespace contractor_management
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Contractor, GetContractor>();
            CreateMap<NewContractor, Contractor>();
            CreateMap<UpdateContractor, Contractor>();
        }
    }
}