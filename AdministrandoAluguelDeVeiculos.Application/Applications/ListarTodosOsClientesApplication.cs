using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class ListarTodosOsClientesApplication : IListarTodosOsClientesApplication
{
    
    private readonly IClienteRepository _clienteRepository;

    public ListarTodosOsClientesApplication(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    
    public async Task<IEnumerable<ClienteViewModel>> ListarTodosOsClientesAsync()
    {
        var clientes = await _clienteRepository.ListarTodosOsClientesAsync();
        return clientes.Select(c => new ClienteViewModel(c.IdCliente,c.ClienteNome,c.ClienteSobrenome ,c.ClienteEmail,c.ClienteContato));
    }
}