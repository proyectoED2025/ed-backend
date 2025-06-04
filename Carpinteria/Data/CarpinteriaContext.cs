using Microsoft.EntityFrameworkCore;
using Carpinteria.Modelo;

namespace Carpinteria.Data
{
    public class CarpinteriaContext : DbContext
    {
        public CarpinteriaContext(DbContextOptions<CarpinteriaContext> options) : base(options) { }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<InsumosNecesarios> InsumosNecesarios { get; set; }
        public DbSet<MovimientoStock> MovimientosStock { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Insumo>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Vidrio>("Vidrio")
                .HasValue<Perfil>("Perfil")
                .HasValue<Accesorio>("Accesorio");
            
          //Esto hace que a la hora de registrar un vidrio, se registre el valor string en lugar de su valor enum.
            modelBuilder.Entity<Vidrio>()
                .Property(v => v.TipoVidrio)
                .HasConversion<string>(); // convierte enum <-> string

            modelBuilder.Entity<Perfil>()
             .Property(p => p.SeriePerfil)
            .HasConversion<string>();

           

            base.OnModelCreating(modelBuilder);
        }
    }
    
    
}
