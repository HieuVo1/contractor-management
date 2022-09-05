using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contractor_management.DTOs.Commons;
using contractor_management.DTOs.Contractor.Request;
using contractor_management.DTOs.Contractor.Response;
using contractor_management.Models;

namespace contractor_management.Services.ContractorService
{
    public interface IContractorService
    {
        public Task<APIResponse<List<GetContractor>>> GetAll();
        public Task<APIResponse<GetContractor>> GetById(string id);
        public Task<APIResponse<GetContractor>> Update(UpdateContractor updateContractor);
        public Task<APIResponse<List<GetContractor>>> Add(NewContractor newContractor);
        public Task<APIResponse<List<GetContractor>>> Delete(string id);
    }
}