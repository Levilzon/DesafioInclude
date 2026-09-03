using System;
using System.Threading.Tasks;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using Microsoft.Extensions.Configuration;

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
}