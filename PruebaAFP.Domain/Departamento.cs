namespace PruebaAFP.Domain
{
    public class Departamento
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int NumEmpleados { get; set; } = 0;
        public string? Nivel { get; set; }
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
    }
}
