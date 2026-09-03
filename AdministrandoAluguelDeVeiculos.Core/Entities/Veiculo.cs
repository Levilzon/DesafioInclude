using AdministrandoAluguelDeVeiculos.Core.Enums;

namespace AdministrandoAluguelDeVeiculos.Core.Entities;

public partial class Veiculo
{
    public Veiculo() { }
    public Veiculo(string marcaVeiculo, string modeloVeiculo, int ano, string placa, double valorDiaria, EStatusDisponibilidade statusDisponibilidade)
    {
        IdVeiculo = Guid.NewGuid();
        MarcaVeiculo = marcaVeiculo;
        ModeloVeiculo  = modeloVeiculo;
        Ano = ano;
        Placa = placa;
        ValorDiaria = valorDiaria;
        StatusDisponibilidade = EStatusDisponibilidade.Disponivel;
    }
    
    public Guid IdVeiculo { get;}

    public string MarcaVeiculo { get;} 

    public string ModeloVeiculo { get;} 

    public int Ano { get;}

    public string Placa { get;} 

    public double ValorDiaria { get;}

    public EStatusDisponibilidade StatusDisponibilidade { get;}
    
}
