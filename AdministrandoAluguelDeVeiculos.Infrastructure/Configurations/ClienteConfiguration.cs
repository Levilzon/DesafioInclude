using AdministrandoAluguelDeVeiculos.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> entity)
    {
        entity.HasKey(e => e.IdCliente).HasName("cliente_pkey");

        entity.ToTable("cliente");

        entity.HasIndex(e => e.ClienteEmail, "cliente_cliente_email_key").IsUnique();

        entity.Property(e => e.IdCliente)
            .HasDefaultValueSql("gen_random_uuid()")
            .HasColumnName("id_cliente");
        entity.Property(e => e.ClienteContato)
            .IsRequired()
            .HasMaxLength(30)
            .HasColumnName("cliente_contato");
        entity.Property(e => e.ClienteEmail)
            .IsRequired()
            .HasMaxLength(40)
            .HasColumnName("cliente_email");
        entity.Property(e => e.ClienteNome)
            .IsRequired()
            .HasMaxLength(40)
            .HasColumnName("cliente_nome");
        entity.Property(e => e.ClienteSenha)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("cliente_senha");
        entity.Property(e => e.ClienteSobrenome)
            .IsRequired()
            .HasMaxLength(40)
            .HasColumnName("cliente_sobrenome");
    }
}