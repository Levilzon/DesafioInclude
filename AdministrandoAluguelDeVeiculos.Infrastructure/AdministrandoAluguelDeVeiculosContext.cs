using System.Reflection;
using Microsoft.EntityFrameworkCore;
using  AdministrandoAluguelDeVeiculos.Core.Entities;
namespace AdministrandoAluguelDeVeiculos.Infrastructure;

public class AdministrandoAluguelDeVeiculosContext(DbContextOptions options) : DbContext(options)
{
   // public virtual DbSet<Aluguel> Aluguels { get; set; }

    public virtual DbSet<Veiculo> Veiculos { get; set; }
   
    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

