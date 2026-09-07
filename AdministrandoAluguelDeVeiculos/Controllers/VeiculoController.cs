using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;

public class VeiculoController : MainController
{
    private readonly ICadastrarVeiculoApplication _cadastrarVeiculoApplication;
    private readonly INotificador _notificador;

    public VeiculoController(ICadastrarVeiculoApplication cadastrarVeiculoApplication,
        INotificador notificador) : base(notificador)
    {
        _cadastrarVeiculoApplication = cadastrarVeiculoApplication;
        _notificador = notificador;
    }
    
    [HttpPost]
    public async Task<IActionResult> CadastrarVeiculoAsync([FromBody] VeiculoInputModel veiculoInputModel)
    {
        var id = await _cadastrarVeiculoApplication.CadastrarVeiculoAsync(veiculoInputModel);
        return Ok(id);
    }
}