using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;


public class ClienteController : MainController
{   
    private readonly ICadastrarClienteApplication  _cadastrarClienteApplication;
    private readonly IListarTodosOsClientesApplication _listarTodosOsClientesApplication;
    private readonly IBuscarClientePorIdApplication _buscarClientePorIdApplication;
    private readonly IClienteAtualizarApplication _clienteAtualizarApplication;
    
    public ClienteController(
        ICadastrarClienteApplication cadastrarClienteApplication,
        IListarTodosOsClientesApplication listarTodosOsClientesApplication,
        IBuscarClientePorIdApplication buscarClientePorIdApplication,
        IClienteAtualizarApplication clienteAtualizarApplication,
        INotificador  notificador) : base(notificador)
         
    {
        _cadastrarClienteApplication = cadastrarClienteApplication;
        _listarTodosOsClientesApplication = listarTodosOsClientesApplication;
        _buscarClientePorIdApplication = buscarClientePorIdApplication;
        _clienteAtualizarApplication = clienteAtualizarApplication;
        
    }

    [HttpPost]
    public async Task<ActionResult> CadastrarClienteAsync([FromBody] ClienteInputModel clienteInputModel)
    {
        var id = await _cadastrarClienteApplication.CadastrarClienteAsync(clienteInputModel);
        return RespostaPersonalizada(Created($"/api/cliente/{id}",id));
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodosOsClientesAsync()
    {
        var clientes = await _listarTodosOsClientesApplication.ListarTodosOsClientesAsync();
        return RespostaPersonalizada(Ok(clientes));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarClientePorIdAsync([FromRoute]Guid id)
    {
        var cliente = await _buscarClientePorIdApplication.BuscarClientePorIdAsync(id);
        if (cliente == null) 
            return NotFound();
        return RespostaPersonalizada(Ok(cliente));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarClienteAsync([FromRoute] Guid id,
        [FromBody] ClienteAtualizarInputModel clienteAtualizarInputModel)
    {
        await _clienteAtualizarApplication.ClienteAtualizarAsync(id, clienteAtualizarInputModel);
        return  RespostaPersonalizada(NoContent());
    }
}
