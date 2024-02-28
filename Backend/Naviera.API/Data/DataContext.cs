using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Naviera.Shared.Entidades;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;


namespace Naviera.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Barco> Barcos { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Contenedor> Contenedores { get; set; }
        public DbSet<Contenido> Contenidos { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TipoContenido> TipoContenidos { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

        }

    }
}
