using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;


public class ClienteController : MainController
{   
    private readonly ICadastrarClienteApplication  _cadastrarClienteApplication;

    public ClienteController(ICadastrarClienteApplication cadastrarClienteApplication)
    {
        _cadastrarClienteApplication = cadastrarClienteApplication;
    }

    [HttpPost]
    public async Task<ActionResult> CadastrarClienteAsync([FromBody] ClienteInputModel clienteInputModel)
    {
        var id = await _cadastrarClienteApplication.CadastrarClienteAsync(clienteInputModel);
        return Ok(id);
    }
    
}
