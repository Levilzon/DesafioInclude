namespace AdministrandoAluguelDeVeiculos.Core.Entities;

public partial class Aluguel
{
    public int IdAluguel { get; set; }

    public int IdVeiculo { get; set; }

    public string NomeCliente { get; set; } = null!;

    public DateOnly DataInicial { get; set; }

    public DateOnly DataFinal { get; set; }
}
