using AdministrandoAluguelDeVeiculos.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Configurations;

public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
{
    public void Configure(EntityTypeBuilder<Veiculo> entity)
    {
        entity.HasKey(e => e.IdVeiculo).HasName("veiculos_pkey");

        entity.ToTable("veiculos");

        entity.HasIndex(e => e.Placa, "veiculos_placa_key").IsUnique();

        entity.Property(e => e.IdVeiculo).HasColumnName("id_veiculo");
        entity.Property(e => e.Ano).HasColumnName("ano");
        entity.Property(e => e.MarcaVeiculo)
            .HasMaxLength(30)
            .HasColumnName("marca_veiculo");
        entity.Property(e => e.ModeloVeiculo)
            .HasMaxLength(30)
            .HasColumnName("modelo_veiculo");
        entity.Property(e => e.Placa)
            .HasMaxLength(10)
            .HasColumnName("placa");
        entity.Property(e => e.ValorDiaria).HasColumnName("valor_diaria");    }
}