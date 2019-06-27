using Hospital.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositoy.dbcontext {
    public class ApplicationDbContext : DbContext {
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }

        public DbSet<Orden> Ordenes { get; set; }

        public DbSet<DetalleOrden> DetalleOrdenes { get; set; }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Paciente> ()
                .Property (p => p.Nombres)
                .HasColumnName ("Nombres")
                .HasMaxLength (50)
                .IsRequired ();

        }
    }
}