using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class ListarTodosOsVeiculosApplication : IListarTodosOsVeiculosApplication
{
    private readonly IVeiculosRepository  _veiculosRepository;
        
    public ListarTodosOsVeiculosApplication( IVeiculosRepository veiculosRepository)
    {
        _veiculosRepository = veiculosRepository;
    }
    public async Task<IEnumerable<VeiculoViewModel>> ListarTodosOsVeiculosAsync()
    {
        var veiculos = await _veiculosRepository.ListarVeiculosAsync();
        return veiculos.Select(c => new VeiculoViewModel(
            c.IdVeiculo,
            c.MarcaVeiculo, 
            c.ModeloVeiculo, 
            c.Ano, 
            c.Placa, 
            c.ValorDiaria, 
            c.StatusDisponibilidade));
    }
}