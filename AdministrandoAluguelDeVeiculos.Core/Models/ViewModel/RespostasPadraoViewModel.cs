namespace AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

public class RespostasPadraoViewModel
{
    public RespostasPadraoViewModel(IEnumerable<string> mensagens, bool sucesso)
    {
        Mensagens = mensagens;
    }
    public IEnumerable<string> Mensagens { get; }
}