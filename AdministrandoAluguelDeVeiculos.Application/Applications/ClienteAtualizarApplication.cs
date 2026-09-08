using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class ClienteAtualizarApplication : IClienteAtualizarApplication
{
    private IClienteRepository _clienteRepository;

    public ClienteAtualizarApplication(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    
    public async Task ClienteAtualizarAsync(Guid id, ClienteAtualizarInputModel clienteAtualizarInputModel)
    {
        var cliente = await _clienteRepository.BuscarClientePorIdAsync(id);
        if (cliente == null)
            throw new NullReferenceException("Cliente não encontrado!");
        cliente
            .SetClienteNome(clienteAtualizarInputModel.ClienteNome)
            .SetSobreNome(clienteAtualizarInputModel.ClienteSobrenome)
            .SetClienteEmail(clienteAtualizarInputModel.ClienteEmail)
            .SetClienteContato(clienteAtualizarInputModel.ClienteContato);
        await _clienteRepository.SalvarMudancasClienteAsync();

    }
}