namespace AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

public class AluguelViewModel
{
    public Guid IdAluguel { get; set; }
    public Guid IdVeiculo { get; set; }
    public string PlacaVeiculo { get; set; }
    public string ModeloVeiculo { get; set; }
    public DateTime DataInicial { get; set; }
    public DateTime DataFinal { get; set; }
    
    public Guid IdCliente { get; set; }
    public string NomeCliente { get; set; }
    public string SobrenomeCliente { get; set; }
    public string ContatoCliente { get; set; }
}