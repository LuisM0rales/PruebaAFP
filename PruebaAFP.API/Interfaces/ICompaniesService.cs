using PruebaAFP.API.DTOs.Companies;
using PruebaAFP.API.DTOs.ResponseV1;

namespace PruebaAFP.API.Interfaces
{
    public interface ICompaniesService
    {
        ResponseWrapperDTO<CompanyResponseDTO> Get(int id);
    }
}
