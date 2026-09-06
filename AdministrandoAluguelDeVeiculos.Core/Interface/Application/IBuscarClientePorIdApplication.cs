using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface IBuscarClientePorIdApplication
{
    Task<ClienteViewModel?> BuscarClientePorIdAsync(Guid id);
}