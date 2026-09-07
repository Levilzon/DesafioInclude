using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;

public interface IVeiculosRepository
{
    Task<Guid> CadastrarVeiculosAsync(Veiculo veiculo);
    
    Task<IEnumerable<Veiculo>> ListarVeiculosAsync();
}