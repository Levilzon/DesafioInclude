using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Mappers;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class BuscarVeiculoPorIdApplication : IBuscarVeiculoPorIdApplication
{
    private IVeiculosRepository _veiculosRepository;

    public BuscarVeiculoPorIdApplication(IVeiculosRepository veiculosRepository)
    {
        _veiculosRepository = veiculosRepository;
    }
    
    public async Task<VeiculoViewModel> BuscarVeiculoPorIdAsync(Guid id)
    {
        var veiculo = await _veiculosRepository.BuscarVeiculoPorIdAsync(id);
        if (veiculo == null)
            return null;
        return veiculo.ToViewModel();
    }
}