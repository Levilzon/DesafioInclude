using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AdministrandoAluguelDeVeiculos.Controllers;


[ApiController]
[Route("/api[controller]")]
public class MainController: ControllerBase
{
    protected readonly INotificador _notificador;
    
    public MainController(INotificador notificador)
    {
        _notificador = notificador;        
    }

    protected ActionResult RespostaPersonalizada(ActionResult actionResult)
    {
        if(OperacaoValida())
            return actionResult;
        var notificacoes = _notificador.ListaNotificacoes();
        var mensagem = notificacoes.Select(m => m.Mensagem);
        return new JsonResult(new RespostasPadraoViewModel(mensagem, false))
        {
            StatusCode = (int)notificacoes.First().HttpStatusCode
        };
    }
    private bool OperacaoValida() => !_notificador.TemNotificacoes();
}