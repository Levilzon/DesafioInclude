
namespace AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

public class VeiculoViewModel
{
    public VeiculoViewModel(Guid id,string marcaVeiculo, string modeloVeiculo, int ano, string placa,
        double valorDiaria, string statusDisponibilidade)
    {
        IdVeiculo = id;
        MarcaVeiculo = marcaVeiculo;
        ModeloVeiculo  = modeloVeiculo;
        Ano = ano;
        Placa = placa;
        ValorDiaria = valorDiaria;
        StatusDisponibilidade = statusDisponibilidade;
    }
    
    public Guid IdVeiculo { get;}

    public string MarcaVeiculo { get;} 

    public string ModeloVeiculo { get;} 

    public int Ano { get;}

    public string Placa { get;} 

    public double ValorDiaria { get;}

    public string StatusDisponibilidade { get;}
}