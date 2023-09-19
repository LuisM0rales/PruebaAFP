using Microsoft.EntityFrameworkCore;
using PruebaAFP.Domain;

namespace PruebaAFP.Data
{
    public class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\sqlexpress; 
                Initial Catalog=Company; Integrated Security=True; TrustServerCertificate=True");
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
