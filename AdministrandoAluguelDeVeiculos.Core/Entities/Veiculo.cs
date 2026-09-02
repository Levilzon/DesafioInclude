namespace AdministrandoAluguelDeVeiculos.Core.Entities;

public partial class Veiculo
{
    public Guid IdVeiculo { get; set; }

    public string MarcaVeiculo { get; set; } = null!;

    public string ModeloVeiculo { get; set; } = null!;

    public int Ano { get; set; }

    public string Placa { get; set; } = null!;

    public double ValorDiaria { get; set; }
    
}
