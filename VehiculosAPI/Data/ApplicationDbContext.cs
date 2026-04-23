using Microsoft.EntityFrameworkCore;
using VehiculosAPI.Entities;
using VehiculosAPI.Entities.Catalogos;

namespace VehiculosAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CatMarca> CatMarcas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<Falla> Fallas { get; set; }
        public DbSet<CatServicio> CatServicios { get; set; }
        public DbSet<CatEstatusFalla> CatEstatusFallas { get; set; }
    }
}
