using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Mappers;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class BuscarClientesPorIdApplication : IBuscarClientePorIdApplication
{
    private IClienteRepository _clienteRepository;
    
    public BuscarClientesPorIdApplication(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<ClienteViewModel?> BuscarClientePorIdAsync(Guid id)
    {
        var cliente = await _clienteRepository.BuscarClientePorIdAsync(id);

        if (cliente == null)
            return null;
        return cliente.ToViewModel();
    }
}
