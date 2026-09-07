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

    public VeiculoController(ICadastrarVeiculoApplication cadastrarVeiculoApplication, 
        IListarTodosOsVeiculosApplication listarTodosOsVeiculosApplication,
        INotificador notificador) : base(notificador)
    {
        _cadastrarVeiculoApplication = cadastrarVeiculoApplication;
        _listarTodosOsVeiculosApplication = listarTodosOsVeiculosApplication;
        _notificador = notificador;
    }
    
    [HttpPost]
    public async Task<IActionResult> CadastrarVeiculoAsync([FromBody] VeiculoInputModel veiculoInputModel)
    {
        var id = await _cadastrarVeiculoApplication.CadastrarVeiculoAsync(veiculoInputModel);
        return Ok(id);
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodosOsVeiculosAsync()
    {
        var veiculos = await _listarTodosOsVeiculosApplication.ListarTodosOsVeiculosAsync();
        return RespostaPersonalizada(Ok(veiculos));
    }
}