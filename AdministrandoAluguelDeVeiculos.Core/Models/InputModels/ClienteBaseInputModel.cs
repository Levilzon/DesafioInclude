namespace AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

public class ClienteBaseInputModel
{
    public ClienteBaseInputModel(string clienteNome, string clienteSobrenome, string clienteEmail ,string clienteContato)
    {
        ClienteNome = clienteNome;
        ClienteSobrenome = clienteSobrenome;
        ClienteEmail = clienteEmail;
        ClienteContato = clienteContato;
    }
    
    public string ClienteNome { get; }
    public string ClienteSobrenome { get;}
    public string ClienteEmail { get; }
    public string ClienteContato { get; }
}