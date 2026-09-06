namespace AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

public  class ClienteAtualizarInputModel : ClienteBaseInputModel
{
    public ClienteAtualizarInputModel(string clienteNome, string clienteSobrenome, string clienteEmail, string clienteContato) : base(clienteNome, clienteSobrenome, clienteEmail, clienteContato)
    {
        
    }
    
} 