using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class CadastrarClienteApplication : ICadastrarClienteApplication
{
    
    private readonly IClienteRepository _clienteRepository;

    public CadastrarClienteApplication(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    
    public async Task<Guid> CadastrarClienteAsync(ClienteInputModel clienteInputModel)
    {
        var cliente = new Cliente(
                clienteInputModel.ClienteNome,
                clienteInputModel.ClienteSobrenome,
                clienteInputModel.ClienteSenha,
                clienteInputModel.ClienteEmail,
                clienteInputModel.ClienteContato
                
            );
        return await _clienteRepository.CadastrarClienteAsync(cliente);

    }
}
