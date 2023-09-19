using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using PruebaAFP.API.DTOs.Companies;
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

            var Companyres = _dbContext.Departamentos.FromSqlInterpolated($@"exec usp_api_getDeparmentsByCompanyId @CompanyId={id}")
                .AsEnumerable().FirstOrDefault();

            ResponseWrapperDTO<DepartmentResponseDTO> response = new ResponseWrapperDTO<DepartmentResponseDTO>();

            if (Companyres != null)
            {
                response.Data = new DepartmentResponseDTO()
                {
                    Id = Companyres.Id,
                    Nombre = Companyres.Nombre,
                    NumEmpleados = Companyres.NumEmpleados,
                    Nivel = Companyres.Nivel

                };
            }

            return response;
        }
    }
}
