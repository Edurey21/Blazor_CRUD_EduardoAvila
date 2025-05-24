using Microsoft.EntityFrameworkCore;

namespace WebAPI_EduardoAvila.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Persona> Personas => Set<Persona>();
    }
}
