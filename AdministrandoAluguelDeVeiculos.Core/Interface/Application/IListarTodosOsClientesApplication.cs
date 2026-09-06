using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface IListarTodosOsClientesApplication
{
    Task<IEnumerable<ClienteViewModel>> ListarTodosOsClientesAsync();
}