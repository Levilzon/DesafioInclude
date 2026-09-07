using System.Net;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;

public interface INotificador
{
    void limparNotificacoes();
    bool TemNotificacoes();
    List<NotificacaoViewModel> ListaNotificacoes();
    void Handle(string mensagem, HttpStatusCode httpStatusCode);
}