using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

public class ClienteInputModels
{
    public ClienteInputModels(string clienteNOme, string clienteSobrenome, string clienteSenha, string clienteEmail, string clienteContato)
    {
        ClienteNome = clienteNOme;
        ClienteSobrenome = clienteSobrenome;
        ClienteSenha = clienteSenha;
        ClienteEmail = clienteEmail;
        ClienteContato = clienteContato;
    }
    
    public string ClienteNome { get; }
    public string ClienteSobrenome { get;}
    public string ClienteSenha { get; }
    public string ClienteEmail { get; }
    public string ClienteContato { get; }

}