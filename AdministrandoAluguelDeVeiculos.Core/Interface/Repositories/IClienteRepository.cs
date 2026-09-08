using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;

public interface IClienteRepository
{
    Task<Guid> CadastrarClienteAsync(Cliente cliente);
    Task<IEnumerable<Cliente>> ListarTodosOsClientesAsync();
    Task<Cliente?> BuscarClientePorIdAsync(Guid id);
    Task SalvarMudancasClienteAsync();
    Task<Cliente> ObterPorIdAsync(Guid idCliente, CancellationToken ct);

}