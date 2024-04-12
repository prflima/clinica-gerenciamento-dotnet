using FSP.PacienteAPI.Data.Configuration;
using FSP.PacienteAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FSP.PacienteAPI.Data
{
    public class PostgreeSQLContext : DbContext
    {
        public PostgreeSQLContext(DbContextOptions<PostgreeSQLContext> opt)
            : base (opt)
        {
            
        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Paciente>().ToTable("Paciente");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EnderecoConfiguration).Assembly);
        }
    }
}
