using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Entities;

public class Cliente
{


    public Cliente(string clienteNome, string clienteSobrenome, string clienteSenha, string clienteEmail, string clienteContato)
    {
        IdCliente = Guid.NewGuid();
        ClienteNome = clienteNome;
        ClienteSobrenome = clienteSobrenome;
        ClienteSenha = clienteSenha;
        ClienteEmail = clienteEmail;
        ClienteContato = clienteContato;
    }
    
    
    
    public Guid IdCliente { get;  }
    public string ClienteNome { get;  }
    public string ClienteSobrenome { get;  }
    public string ClienteSenha { get;  }
    public string ClienteEmail { get;  }
    public string ClienteContato { get; }

   
}