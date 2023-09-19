using PruebaAFP.API.DTOs.Departments;
using PruebaAFP.API.DTOs.ResponseV1;

namespace PruebaAFP.API.Interfaces
{
    public interface IDeparmentsService
    {
        ResponseWrapperDTO<DepartmentResponseDTO> Get(int id);
    }
}
