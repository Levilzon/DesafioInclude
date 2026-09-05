using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface ICadastrarClienteApplication
{
    Task<Guid> CadastrarClienteAsync(ClienteInputModels clienteInputModels);
}