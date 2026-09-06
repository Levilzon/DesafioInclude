using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;

public class VeiculoController : MainController
{
    private readonly ICadastrarVeiculoApplication _cadastrarVeiculoApplication;

    public VeiculoController(ICadastrarVeiculoApplication cadastrarVeiculoApplication)
    {
        _cadastrarVeiculoApplication = cadastrarVeiculoApplication;
    }
    
    [HttpPost]
    public async Task<IActionResult> CadastrarVeiculoAsync([FromBody] VeiculoInputModel veiculoInputModel)
    {
        var id = await _cadastrarVeiculoApplication.CadastrarVeiculoAsync(veiculoInputModel);
        return Ok(id);
    }
}