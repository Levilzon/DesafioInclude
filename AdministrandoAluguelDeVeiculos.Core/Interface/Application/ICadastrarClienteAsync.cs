using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface ICadastrarClienteAsync
{
    Task<Guid> CadastrarClienteAsync(Cliente cliente);
}