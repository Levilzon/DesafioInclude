using System.Net;
using AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Application.Notifications;

public class Notificador : INotificador
{    
    private readonly List<NotificacaoViewModel> _notificacoes;

    public Notificador()
    {
        _notificacoes = [];
    }

    public void limparNotificacoes()
    {
        if (_notificacoes.Count > 0)
        {
            _notificacoes.Clear();
        }
    }

    public bool TemNotificacoes()
    {
        return _notificacoes.Count > 0;

    }

    public List<NotificacaoViewModel> ListaNotificacoes()
    {
        return _notificacoes;
    }

    public void Handle(string mensagem, HttpStatusCode httpStatusCode)
    {
        _notificacoes.Add( new(mensagem, httpStatusCode));
        
    }
}