using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface IBuscarVeiculoPorIdApplication
{
    Task<VeiculoViewModel> BuscarVeiculoPorIdAsync(Guid id);
}