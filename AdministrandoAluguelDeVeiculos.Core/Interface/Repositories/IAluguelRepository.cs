using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;

public interface IAluguelRepository
{
    Task<Aluguel?> ObterAluguelAtivoPorVeiculoIdAsync(Guid idVeiculo, CancellationToken ct);
    Task AdicionarAsync(Aluguel aluguel, CancellationToken ct);
    Task CommitAsync(CancellationToken ct);
}