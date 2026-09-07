using System.Net;

namespace AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

public class NotificacaoViewModel
{
    public NotificacaoViewModel(string mensagem, HttpStatusCode httpStatusCode)
    {
        Mensagem = mensagem;
        HttpStatusCode = httpStatusCode;
    }
    
    public string Mensagem { get; }
    public HttpStatusCode HttpStatusCode { get;}
}