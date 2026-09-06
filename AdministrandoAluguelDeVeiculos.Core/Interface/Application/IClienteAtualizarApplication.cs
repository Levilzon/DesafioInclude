using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface IClienteAtualizarApplication
{
    Task ClienteAtualizarAsync(Guid id, ClienteAtualizarInputModel clienteAtualizarInputModel);
}