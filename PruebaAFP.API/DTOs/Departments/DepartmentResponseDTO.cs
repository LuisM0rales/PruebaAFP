namespace PruebaAFP.API.DTOs.Departments
{
    public class DepartmentResponseDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int NumEmpleados { get; set; } = 0;
        public string? Nivel { get; set; }
    }
}
