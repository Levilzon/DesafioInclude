using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class VeiculoAtualizarApplication : IVeiculoAtualizarApplication
{
    private IVeiculosRepository _veiculosRepository;

    public VeiculoAtualizarApplication(IVeiculosRepository veiculosRepository)
    {
        _veiculosRepository = veiculosRepository;
    }
    public async Task VeiculoAtualizarAsync(Guid id, VeiculoAtualizarInputModel veiculoAtualizarInputModel)
    {
        var veiculo = await _veiculosRepository.BuscarVeiculoPorIdAsync(id);
        if (veiculo == null)
            throw new NullReferenceException("Veiculo não encontrado!");
        veiculo
            .SetMarcaVeiculo(veiculoAtualizarInputModel.MarcaVeiculo)
            .SetModeloVeiculo(veiculoAtualizarInputModel.ModeloVeiculo)
            .SetAno(veiculoAtualizarInputModel.Ano)
            .SetPlaca(veiculoAtualizarInputModel.Placa)
            .SetValorDiaria(veiculoAtualizarInputModel.ValorDiaria)
            .SetStatusDisponibilidade(veiculoAtualizarInputModel.StatusDisponibilidade);
        await _veiculosRepository.SalvarMudancasAsync();
    }
}