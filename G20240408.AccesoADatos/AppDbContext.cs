
using G20240408.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;

namespace G20240408.AccesoADatos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PersonaG> PersonasG { get; set; }

    }
}
