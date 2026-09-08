using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Repositories;

public class VeiculoRepository : IVeiculosRepository
{
    private readonly AdministrandoAluguelDeVeiculosContext _dbcontext;

    public VeiculoRepository(AdministrandoAluguelDeVeiculosContext dbContext)
    {
        _dbcontext = dbContext;
    }
    
    public async Task<Guid> CadastrarVeiculosAsync(Veiculo veiculo)
    {
       var entidade = await _dbcontext.Veiculos.AddAsync(veiculo);
       await _dbcontext.SaveChangesAsync();
       return entidade.Entity.IdVeiculo;
    }

    public async Task<IEnumerable<Veiculo>> ListarVeiculosAsync()
    {
        var veiculos = await _dbcontext.Veiculos.ToListAsync();
        return veiculos;
    }

    public async Task<Veiculo> BuscarVeiculoPorIdAsync(Guid id)
    {
        var veiculo = await _dbcontext.Veiculos.FirstOrDefaultAsync(v => v.IdVeiculo == id);
        return veiculo;
    }

    public Task SalvarMudancasAsync()
    {
        return _dbcontext.SaveChangesAsync();
    }
}