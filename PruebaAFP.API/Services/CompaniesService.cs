using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PruebaAFP.API.DTOs.Companies;
using PruebaAFP.API.DTOs.ResponseV1;
using PruebaAFP.API.Interfaces;
using PruebaAFP.Data;

namespace PruebaAFP.API.Services
{
    public class CompaniesService : ICompaniesService
    {
        private readonly IExceptionHandlerFeature _handler;
        private readonly CompanyDbContext _dbContext;
        public CompaniesService()
        {
            _handler = new ExceptionHandlerFeature();
            _dbContext = new CompanyDbContext();
        }

        public ResponseWrapperDTO<CompanyResponseDTO> Get(int id)
        {

            var Companyres = _dbContext.Companies.FromSqlInterpolated($@"exec usp_api_getCompanyById @CompanyId={id}")
                .AsEnumerable().FirstOrDefault();

        ResponseWrapperDTO<CompanyResponseDTO> response = new ResponseWrapperDTO<CompanyResponseDTO>();

            if(Companyres != null)
            {
                response.Data = new CompanyResponseDTO()
                {
                    Id = Companyres.Id,
                    Nombre = Companyres.Nombre,
                    RazonSocial = Companyres.RazonSocial,
                    FechaRegistro = Companyres.FechaRegistro,
                    FechaCreacion = Companyres.FechaCreacion,
                    UsuarioCreo = Companyres.UsuarioCreo,
                    FechaModificacion = Companyres.FechaModificacion,
                    UsuarioModifico = Companyres.UsuarioModifico
                };
            }

            return response;
        }
    }
}
