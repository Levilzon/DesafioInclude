using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

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

    public async Task<IEnumerable<Cliente>> ListarTodosOsClientesAsync()
    {
        var cliente = await _dbContext.Clientes.ToListAsync();
        return cliente;
    }
 
    public async Task<Cliente> BuscarClientePorIdAsync(Guid id)
    {
        var cliente = await _dbContext.Clientes.FirstOrDefaultAsync(c => c.IdCliente == id);
        return cliente;
    }
}