using AdministrandoAluguelDeVeiculos.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Configurations;

public class AluguelConfiguration :IEntityTypeConfiguration<Aluguel>
{
    public void Configure(EntityTypeBuilder<Aluguel> entity)
    {
        entity.HasKey(e => e.IdAluguel).HasName("aluguel_pkey");

        entity.ToTable("aluguel");

        entity.Property(e => e.IdAluguel).HasColumnName("id_aluguel");
        entity.Property(e => e.DataFinal).HasColumnName("data_final");
        entity.Property(e => e.DataInicial).HasColumnName("data_inicial");
        entity.Property(e => e.IdVeiculo).HasColumnName("id_veiculo");
        entity.Property(e => e.NomeCliente)
            .HasMaxLength(150)
            .HasColumnName("nome_cliente");
    }
}
