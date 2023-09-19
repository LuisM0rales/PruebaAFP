using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using PruebaAFP.API.DTOs.Departments;
using PruebaAFP.API.DTOs.ResponseV1;
using PruebaAFP.API.Interfaces;
using PruebaAFP.Data;

namespace PruebaAFP.API.Services
{
    public class DepartmentsService : IDeparmentsService
    {
        private readonly IExceptionHandlerFeature _handler;
        private readonly CompanyDbContext _dbContext;
        public DepartmentsService()
        {
            _handler = new ExceptionHandlerFeature();
            _dbContext = new CompanyDbContext();
        }

        public ResponseWrapperDTO<DepartmentResponseDTO> Get(int id)
        {

            var Companyres = _dbContext.Departamentos.FromSqlInterpolated($@"exec usp_api_getDeparmentsByCompanyId @CompanyId={id}");
            ResponseWrapperDTO<DepartmentResponseDTO> response = new ResponseWrapperDTO<DepartmentResponseDTO>();

            response.Data.Id = Companyres.SingleOrDefault().Id;
            response.Data.Nombre = Companyres.SingleOrDefault().Nombre;
            response.Data.NumEmpleados = Companyres.SingleOrDefault().NumEmpleados;
            response.Data.Nivel = Companyres.SingleOrDefault().Nivel;


            return response;
        }
    }
}
