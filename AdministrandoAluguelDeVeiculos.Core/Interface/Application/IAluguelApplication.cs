using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Application;

public interface IAluguelApplication
{
    Task<Guid?> AlugarVeiculoPorPlacaAsync(string placa, Guid idCliente, DateTime dataInicial, DateTime dataFinal, CancellationToken ct);
    Task<AluguelViewModel?> ObterAluguelPorPlacaAsync(string placa, CancellationToken ct);
}