using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using contractor_management.DTOs.Commons;
using contractor_management.DTOs.Contractor.Request;
using contractor_management.DTOs.Contractor.Response;
using contractor_management.Models;

namespace contractor_management.Services.ContractorService
{
    public class ContractorService : IContractorService
    {
        private readonly IMapper _mapper;

        public ContractorService(IMapper mapper)
        {
            _mapper = mapper;
        }
        private List<Contractor> contractors = new List<Contractor>(){
            new Contractor(){ Id = "1", Name = "DMS"},
            new Contractor(){ Id = "2", Name = "DNM"},
            new Contractor(){ Id = "3", Name = "AMS"}
        };

        public async Task<APIResponse<List<GetContractor>>> Add(NewContractor newContractor)
        {
            contractors.Add(_mapper.Map<Contractor>(newContractor));
            var result = contractors.Select(c => _mapper.Map<GetContractor>(c)).ToList();
            return new APISuccessResponse<List<GetContractor>>(result);
        }

        public async Task<APIResponse<List<GetContractor>>> GetAll()
        {
            var result = contractors.Select(c => _mapper.Map<GetContractor>(c)).ToList();
            return new APISuccessResponse<List<GetContractor>>(result);
        }

        public async Task<APIResponse<GetContractor>> GetById(string id)
        {
            var result = _mapper.Map<GetContractor>(contractors.FirstOrDefault(c => c.Id == id));
            return new APISuccessResponse<GetContractor>(result);
        }

        public async Task<APIResponse<GetContractor>> Update(UpdateContractor updateContractor)
        {
            Contractor contractor = contractors.FirstOrDefault(c => c.Id == updateContractor.Id);
            _mapper.Map(updateContractor, contractor);
            var result = _mapper.Map<GetContractor>(contractor);
            return new APISuccessResponse<GetContractor>(result);
        }

        public async Task<APIResponse<List<GetContractor>>> Delete(string id)
        {
            Contractor contractor = contractors.First(c => c.Id == id);
            contractors.Remove(contractor);
            var result = contractors.Select(c => _mapper.Map<GetContractor>(c)).ToList();
            return new APISuccessResponse<List<GetContractor>>(result);
        }
    }
}