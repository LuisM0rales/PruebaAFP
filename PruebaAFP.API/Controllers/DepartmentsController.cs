using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAFP.API.DTOs.Departments;
using PruebaAFP.API.DTOs.ResponseV1;
using PruebaAFP.API.Interfaces;
using PruebaAFP.API.Services;

namespace PruebaAFP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDeparmentsService _departmentsService = new DepartmentsService();

        [HttpGet("{id:int}")]
        public ResponseWrapperDTO<DepartmentResponseDTO> Get(int id)
        {
            ResponseWrapperDTO<DepartmentResponseDTO> res = _departmentsService.Get(id);

            return res;
        }
    }
}
