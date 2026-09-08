using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;

public interface IVeiculosRepository
{
    Task<Guid> CadastrarVeiculosAsync(Veiculo veiculo);
    Task<IEnumerable<Veiculo>> ListarVeiculosAsync();
    Task<Veiculo> BuscarVeiculoPorIdAsync(Guid id);
    Task SalvarMudancasAsync();
    Task<Veiculo?> ObterPorPlacaOuIdAsync(string placa, CancellationToken ct);
    Task<Veiculo?> ObterPorIdAsync(Guid id, CancellationToken ct);
    Task<Veiculo?> ObterPorPlacaAsync(string placa, CancellationToken ct);
    void Atualizar(Veiculo veiculo); 
    
}