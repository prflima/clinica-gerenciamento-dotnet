using FSP.PacienteAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSP.PacienteAPI.Data.Configuration
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property (p => p.Telefone)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(p => p.CPF)
                .HasMaxLength(11)
                .IsRequired();

            builder
                .HasMany(p => p.Enderecos)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .IsRequired();
        }
    }
}
