using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface ICadastrarVeiculoApplication
{
    Task<Guid> CadastrarVeiculoAsync(VeiculoInputModel veiculoInputModel);
}