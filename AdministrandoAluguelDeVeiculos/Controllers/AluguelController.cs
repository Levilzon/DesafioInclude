using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlugueisController : MainController
{
    private readonly IAluguelApplication _application;

    public AlugueisController(IAluguelApplication application, INotificador notificador) : base(notificador)
    {
        _application = application;
    }

    [HttpPut("alugar-por-placa")]
    public async Task<IActionResult> AlugarPorPlaca(
        [FromQuery] string placa, 
        [FromQuery] Guid clienteId, 
        [FromQuery] DateTime dataInicial, 
        [FromQuery] DateTime dataFinal, 
        CancellationToken ct)
    {
        try
        {
            var aluguelId = await _application.AlugarVeiculoPorPlacaAsync(placa, clienteId, dataInicial, dataFinal, ct);
            if (aluguelId is null) return NotFound("Veículo ou Cliente não encontrado.");
        
            return Ok(new { IdAluguel = aluguelId, Mensagem = "Veículo alugado com sucesso!" });
        }
        catch (ValidationException ex)
        {
            return BadRequest(string.Join(" | ", ex.Errors.Select(e => e.ErrorMessage)));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("veiculo/{placa}")]
    public async Task<IActionResult> ObterAluguel(string placa, CancellationToken ct)
    {
        var aluguel = await _application.ObterAluguelPorPlacaAsync(placa, ct);
        if (aluguel is null) return NotFound("Veículo não está alugado.");
        
        return Ok(aluguel);
    }
}