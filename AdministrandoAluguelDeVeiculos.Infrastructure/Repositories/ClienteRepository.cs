using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AdministrandoAluguelDeVeiculosContext _dbContext;

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
        return await _dbContext.Clientes.ToListAsync();
    }
 
    public async Task<Cliente> BuscarClientePorIdAsync(Guid id)
    {
        return await _dbContext.Clientes.FirstOrDefaultAsync(c => c.IdCliente == id);
    }

    public async Task<Cliente> ObterPorIdAsync(Guid idCliente, CancellationToken ct)
    {
        return await _dbContext.Clientes.FirstOrDefaultAsync(c => c.IdCliente == idCliente, ct);
    }

    public async Task SalvarMudancasClienteAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}