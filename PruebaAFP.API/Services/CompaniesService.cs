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
                .AsEnumerable();
            ResponseWrapperDTO<CompanyResponseDTO> response = new ResponseWrapperDTO<CompanyResponseDTO>();

            response.Data.Id = Companyres.SingleOrDefault().Id;
            response.Data.Nombre = Companyres.SingleOrDefault().Nombre;
            response.Data.RazonSocial = Companyres.SingleOrDefault().RazonSocial;
            response.Data.FechaRegistro = Companyres.SingleOrDefault().FechaRegistro;
            response.Data.FechaCreacion = Companyres.SingleOrDefault().FechaCreacion;
            response.Data.UsuarioCreo = Companyres.SingleOrDefault().UsuarioCreo;
            response.Data.FechaModificacion = Companyres.SingleOrDefault().FechaModificacion;
            response.Data.UsuarioModifico = Companyres.SingleOrDefault().UsuarioModifico;


            return response;
        }
    }
}
