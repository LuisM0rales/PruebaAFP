using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAFP.API.DTOs.Companies;
using PruebaAFP.API.DTOs.ResponseV1;
using PruebaAFP.API.Interfaces;
using PruebaAFP.API.Services;

namespace PruebaAFP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesService _companiesService = new CompaniesService();

        [HttpGet("{id:int}")]
        public ResponseWrapperDTO<CompanyResponseDTO> Get(int id)
        {
            ResponseWrapperDTO<CompanyResponseDTO> res = _companiesService.Get(id);

            return res;
        }
    }
}
