using System.IO.Pipes;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class CadastrarVeiculoApplication : ICadastrarVeiculoApplication
{
    private readonly IVeiculosRepository _veiculosRepository;
    
    public CadastrarVeiculoApplication(IVeiculosRepository veiculosRepository)
    {
        _veiculosRepository = veiculosRepository;
    }


    public async Task<Guid> CadastrarVeiculoAsync(VeiculoInputModels veiculoInputModels)
    {
        var veiculo = new Veiculo(
            veiculoInputModels.MarcaVeiculo,
            veiculoInputModels.ModeloVeiculo,
            veiculoInputModels.Ano,
            veiculoInputModels.Placa,
            veiculoInputModels.ValorDiaria,
            veiculoInputModels.StatusDisponibilidade
            );
        return await _veiculosRepository.CadastrarVeiculosAsync(veiculo);
        
    }
}
