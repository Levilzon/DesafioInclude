using System;
using System.Threading.Tasks;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    AdministrandoAluguelDeVeiculosContext _dbContext;

    public ClienteRepository(AdministrandoAluguelDeVeiculosContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    
    public async Task<Guid> CadastrarClienteAsync(Cliente cliente)
    {
        var entidade = await _dbContext.Clientes.AddAsync(cliente);
        await _dbContext.SaveChangesAsync();
        return entidade.Entity.IdCliente;
    }
}