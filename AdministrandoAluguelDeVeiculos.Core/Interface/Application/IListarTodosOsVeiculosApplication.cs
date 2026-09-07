using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface IListarTodosOsVeiculosApplication
{
    Task<IEnumerable<VeiculoViewModel>> ListarTodosOsVeiculosAsync();
}