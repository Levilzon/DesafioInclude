using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;

public class VeiculoController : MainController
{
    private readonly ICadastrarVeiculoApplication _cadastrarVeiculoApplication;
    private readonly INotificador _notificador;
    private readonly IListarTodosOsVeiculosApplication _listarTodosOsVeiculosApplication;
    private readonly IBuscarVeiculoPorIdApplication _buscarVeiculoPorIdApplication;
    private readonly IVeiculoAtualizarApplication _veiculoAtualizarApplication;

    public VeiculoController(ICadastrarVeiculoApplication cadastrarVeiculoApplication, 
        IListarTodosOsVeiculosApplication listarTodosOsVeiculosApplication,
        INotificador notificador,
        IBuscarVeiculoPorIdApplication buscarVeiculoPorIdApplication,
        IVeiculoAtualizarApplication veiculoAtualizarApplication) : base(notificador)
    {
        _cadastrarVeiculoApplication = cadastrarVeiculoApplication;
        _listarTodosOsVeiculosApplication = listarTodosOsVeiculosApplication;
        _notificador = notificador;
        _buscarVeiculoPorIdApplication = buscarVeiculoPorIdApplication;
        _veiculoAtualizarApplication = veiculoAtualizarApplication;
    }
    
    [HttpPost]
    public async Task<IActionResult> CadastrarVeiculoAsync([FromBody] VeiculoInputModel veiculoInputModel)
    {
        var id = await _cadastrarVeiculoApplication.CadastrarVeiculoAsync(veiculoInputModel);
        return RespostaPersonalizada(Created($"/api/veiculo/{id}",id));
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodosOsVeiculosAsync()
    {
        var veiculos = await _listarTodosOsVeiculosApplication.ListarTodosOsVeiculosAsync();
        return RespostaPersonalizada(Ok(veiculos));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarVeiculoPorIdAsync([FromBody]Guid id)
    {
        var veiculo = await _buscarVeiculoPorIdApplication.BuscarVeiculoPorIdAsync(id);
        if (veiculo == null)
            return NotFound();
        return RespostaPersonalizada(Ok(veiculo));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> SalvarMudancasVeiculoAsync([FromRoute]Guid id, 
        [FromBody] VeiculoAtualizarInputModel veiculoAtualizarInputModel )
    {
        await _veiculoAtualizarApplication.VeiculoAtualizarAsync(id, veiculoAtualizarInputModel);
        return RespostaPersonalizada(NoContent());
    }
    
}