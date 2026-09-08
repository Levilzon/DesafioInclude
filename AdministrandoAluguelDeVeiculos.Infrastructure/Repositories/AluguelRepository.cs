using System;
using System.Threading;
using System.Threading.Tasks;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AdministrandoAluguelDeVeiculos.Infrastructure.Repositories;

public class AluguelRepository : IAluguelRepository
{
    private readonly AdministrandoAluguelDeVeiculosContext _context;

    public AluguelRepository(AdministrandoAluguelDeVeiculosContext context)
    {
        _context = context;
    }

    public async Task<Aluguel?> ObterAluguelAtivoPorVeiculoIdAsync(Guid idVeiculo, CancellationToken ct)
    {
        return await _context.Alugueis
            .Include(a => a.Cliente)
            .Include(a => a.Veiculo)
            .FirstOrDefaultAsync(a => a.IdVeiculo == idVeiculo && a.DataFinal > DateTime.Now, ct);
    }

    public async Task AdicionarAsync(Aluguel aluguel, CancellationToken ct)
    {
        await _context.Alugueis.AddAsync(aluguel, ct);
    }

    public async Task CommitAsync(CancellationToken ct)
    {
        await _context.SaveChangesAsync(ct);
    }
}