namespace AdministrandoAluguelDeVeiculos.Core.Entities;

public class Aluguel
{
    public Aluguel(Guid idCliente, Guid idVeiculo, DateTime dataInicial, DateTime dataFinal)
    {
        IdAluguel = Guid.NewGuid();
        IdCliente = idCliente;
        IdVeiculo = idVeiculo;
        DataInicial = dataInicial;
        DataFinal = dataFinal;
    }

    public Guid IdAluguel { get; private set; }
    public Guid IdCliente { get; private set; }
    public Guid IdVeiculo { get; private set; }
    public DateTime DataInicial { get; private set; }
    public DateTime DataFinal { get; private set; }
    public Cliente Cliente { get; private set; }
    public Veiculo Veiculo { get; private set; }

    public void VincularClienteEVeiculo(Cliente cliente, Veiculo veiculo)
    {
        Cliente = cliente;
        Veiculo = veiculo;
    }
}