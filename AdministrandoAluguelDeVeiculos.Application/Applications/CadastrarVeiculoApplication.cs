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


    public async Task<Guid> CadastrarVeiculoAsync(VeiculoInputModel veiculoInputModel)
    {
        var veiculo = new Veiculo(
            veiculoInputModel.MarcaVeiculo,
            veiculoInputModel.ModeloVeiculo,
            veiculoInputModel.Ano,
            veiculoInputModel.Placa,
            veiculoInputModel.ValorDiaria,
            veiculoInputModel.StatusDisponibilidade
            );
        return await _veiculosRepository.CadastrarVeiculosAsync(veiculo);
        
    }
}
