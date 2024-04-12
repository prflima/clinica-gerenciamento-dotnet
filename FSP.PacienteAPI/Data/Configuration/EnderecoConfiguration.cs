using FSP.PacienteAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSP.PacienteAPI.Data.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(e => e.Rua)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(e => e.Numero)
                .IsRequired();

            builder
                .HasOne(e => e.Paciente)
                .WithMany(p => p.Enderecos)
                .HasForeignKey(e => e.PacienteId)
                .IsRequired();
        }
    }
}
