using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Repositories;

public class VeiculoRepository : IVeiculosRepository
{
    private readonly AdministrandoAluguelDeVeiculosContext _dbContext;

    public VeiculoRepository(AdministrandoAluguelDeVeiculosContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Guid> CadastrarVeiculosAsync(Veiculo veiculo)
    {
        var entidade = await _dbContext.Veiculos.AddAsync(veiculo);
        await _dbContext.SaveChangesAsync();
        return entidade.Entity.IdVeiculo;
    }

    public async Task<IEnumerable<Veiculo>> ListarVeiculosAsync()
    {
        return await _dbContext.Veiculos.ToListAsync();
    }

    public async Task<Veiculo> BuscarVeiculoPorIdAsync(Guid id)
    {
        return await _dbContext.Veiculos.FirstOrDefaultAsync(v => v.IdVeiculo == id);
    }

    public async Task SalvarMudancasAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Veiculo?> ObterPorPlacaAsync(string placa, CancellationToken ct)
    {
        return await _dbContext.Veiculos
            .FirstOrDefaultAsync(v => v.Placa == placa, ct);
    }

    public async Task<Veiculo?> ObterPorPlacaOuIdAsync(string placaOuId, CancellationToken ct)
    {
        return await _dbContext.Veiculos
            .FirstOrDefaultAsync(v => v.Placa == placaOuId || v.IdVeiculo.ToString() == placaOuId, ct);
    }

    public async Task<Veiculo?> ObterPorIdAsync(Guid id, CancellationToken ct)
    {
        return await _dbContext.Veiculos.FindAsync(id, ct);
    }

    public void Atualizar(Veiculo veiculo)
    {
        _dbContext.Veiculos.Update(veiculo);
    }
}