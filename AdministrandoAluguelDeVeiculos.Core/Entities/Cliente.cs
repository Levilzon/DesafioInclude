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
    public string ClienteNome { get; private set; }
    public string ClienteSobrenome { get; private set; }
    public string ClienteSenha { get;  }
    public string ClienteEmail { get; private set; }
    public string ClienteContato { get; private set; }

    public Cliente SetClienteNome(string clienteNome)
    {
        ClienteNome = clienteNome;
        return this;
    }

    public Cliente SetSobreNome(string clienteSobreNome)
    {
        ClienteSobrenome = clienteSobreNome;
        return this;
    }

    public Cliente SetClienteEmail(string clienteEmail)
    {
        ClienteEmail = clienteEmail;
        return this;
    }

    public Cliente SetClienteContato(string clienteContato)
    {
        ClienteContato = clienteContato;
        return this;
    }
}