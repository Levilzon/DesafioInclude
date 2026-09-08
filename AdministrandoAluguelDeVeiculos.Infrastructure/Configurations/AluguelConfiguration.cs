using AdministrandoAluguelDeVeiculos.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Configurations;

public class AluguelConfiguration : IEntityTypeConfiguration<Aluguel>
{
    public void Configure(EntityTypeBuilder<Aluguel> builder)
    {
        builder.ToTable("aluguel");
        builder.HasKey(a => a.IdAluguel);
        builder.Property(a => a.IdAluguel)
            .HasColumnName("id_aluguel");

        builder.Property(a => a.DataInicial)
            .HasColumnName("data_inicial")
            .HasColumnType("date");
        builder.Property(a => a.DataFinal)
            .HasColumnName("data_final")
            .HasColumnType("date");;

        builder.Property(a => a.IdCliente)
            .HasColumnName("id_cliente");
        builder.Property(a => a.IdVeiculo)
            .HasColumnName("id_veiculo");

        builder.HasOne(a => a.Cliente)
            .WithMany(c => c.Alugueis)
            .HasForeignKey(a => a.IdCliente);

        builder.HasOne(a => a.Veiculo)
            .WithMany(v => v.Alugueis)
            .HasForeignKey(a => a.IdVeiculo);
    }
}