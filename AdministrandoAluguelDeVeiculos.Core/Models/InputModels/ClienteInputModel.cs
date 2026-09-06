using AdministrandoAluguelDeVeiculos.Core.Entities;

namespace AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

public class ClienteInputModel :ClienteBaseInputModel
{
    public ClienteInputModel(string clienteNome, string clienteSobrenome, string clienteSenha, string clienteEmail, string clienteContato) : base(clienteNome, clienteSobrenome, clienteEmail, clienteContato)
    {
        ClienteSenha = clienteSenha;
    }
    
    public string ClienteSenha { get; }

}