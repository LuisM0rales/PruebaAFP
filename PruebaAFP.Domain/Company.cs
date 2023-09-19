namespace PruebaAFP.Domain
{
    public class Company
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? RazonSocial { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public string? UsuarioCreo { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifico { get; set; }
    }
}
