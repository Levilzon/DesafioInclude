namespace AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

public class ClienteViewModel
{
    public ClienteViewModel(Guid id, string clienteNome, string clienteEmail, string clienteContato)
    {
        IdCliente = id;
        ClienteNome = clienteNome;
        ClienteEmail = clienteEmail;
        ClienteContato = clienteContato;
        
    }
    
    
    public  Guid IdCliente { get; }
    public string ClienteNome { get; }
    public string ClienteEmail { get; }
    public string ClienteContato { get; }
}