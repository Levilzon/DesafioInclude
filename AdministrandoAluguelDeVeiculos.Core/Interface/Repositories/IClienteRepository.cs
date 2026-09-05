using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;

public interface IClienteRepository
{
    Task<Guid> CadastrarClienteAsync(Cliente cliente);
}