using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contractor_management.DTOs.Commons;
using contractor_management.DTOs.Contractor.Request;
using contractor_management.DTOs.Contractor.Response;
using contractor_management.Models;
using contractor_management.Services.ContractorService;
using Microsoft.AspNetCore.Mvc;

namespace contractor_management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractorController : ControllerBase
    {
        private readonly IContractorService _contractorService;

        public ContractorController(IContractorService contractorService)
        {
            _contractorService = contractorService;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<APIResponse<IEnumerable<GetContractor>>>> GetAll()
        {
            return Ok(_contractorService.GetAll());
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<APIResponse<GetContractor>>> Get(string id)
        {
            return Ok(_contractorService.GetById(id));
        }

        [HttpPost("add")]
        public async Task<ActionResult<APIResponse<IEnumerable<GetContractor>>>> Post(NewContractor contractor)
        {
            return Ok(_contractorService.Add(contractor));
        }

        [HttpPut("update")]
        public async Task<ActionResult<APIResponse<IEnumerable<GetContractor>>>> Update(UpdateContractor updateContractor)
        {
            return Ok(_contractorService.Update(updateContractor));
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<APIResponse<IEnumerable<GetContractor>>>> Delete(string id)
        {
            return Ok(_contractorService.Delete(id));
        }
    }
}