using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;


public class ClienteController : MainController
{   
    private readonly ICadastrarClienteApplication  _cadastrarClienteApplication;
    private readonly IListarTodosOsClientesApplication _listarTodosOsClientesApplication;
    private readonly IBuscarClientePorIdApplication _buscarClientePorIdApplication;
    public ClienteController(ICadastrarClienteApplication cadastrarClienteApplication,
        IListarTodosOsClientesApplication listarTodosOsClientesApplication,
        IBuscarClientePorIdApplication buscarClientePorIdApplication)
    {
        _cadastrarClienteApplication = cadastrarClienteApplication;
        _listarTodosOsClientesApplication = listarTodosOsClientesApplication;
        _buscarClientePorIdApplication = buscarClientePorIdApplication;
    }

    [HttpPost]
    public async Task<ActionResult> CadastrarClienteAsync([FromBody] ClienteInputModel clienteInputModel)
    {
        var id = await _cadastrarClienteApplication.CadastrarClienteAsync(clienteInputModel);
        return Ok(id);
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodosOsClientesAsync()
    {
        var clientes = await _listarTodosOsClientesApplication.ListarTodosOsClientesAsync();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarClientePorIdAsync([FromRoute]Guid id)
    {
        var cliente = await _buscarClientePorIdApplication.BuscarClientePorIdAsync(id);
        if (cliente == null) 
            return NotFound();
        return Ok(cliente);
    }
}
