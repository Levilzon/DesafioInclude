using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface IVeiculoAtualizarApplication
{
    Task VeiculoAtualizarAsync(Guid id,VeiculoAtualizarInputModel veiculoAtualizarInputModel);
}