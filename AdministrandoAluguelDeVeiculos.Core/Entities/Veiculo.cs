using AdministrandoAluguelDeVeiculos.Core.Enums;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Entities;

public partial class Veiculo
{
    public Veiculo() { }
    public Veiculo(string marcaVeiculo, string modeloVeiculo, int ano, string placa,
        double valorDiaria, EStatusDisponibilidade statusDisponibilidade)
    {
        IdVeiculo = Guid.NewGuid();
        MarcaVeiculo = marcaVeiculo;
        ModeloVeiculo  = modeloVeiculo;
        Ano = ano;
        Placa = placa;
        ValorDiaria = valorDiaria;
        StatusDisponibilidade = EStatusDisponibilidade.disponivel;
    }
    
    public Guid IdVeiculo { get;}

    public string MarcaVeiculo { get; private set; } 

    public string ModeloVeiculo { get; private set; } 

    public int Ano { get; private set; }

    public string Placa { get; private set; } 

    public double ValorDiaria { get; private set; }

    public EStatusDisponibilidade StatusDisponibilidade { get; private set; }

    public Veiculo SetMarcaVeiculo(string marcaVeiculo)
    {
        MarcaVeiculo = marcaVeiculo;
        return this;
    }

    public Veiculo SetModeloVeiculo(string modeloVeiculo)
    {
        ModeloVeiculo = modeloVeiculo;
        return this;
    }

    public Veiculo SetAno(int ano)
    {
        Ano = ano;
        return this;
    }

    public Veiculo SetPlaca(string placa)
    {
        Placa = placa;
        return this;
    }

    public Veiculo SetValorDiaria(double valorDiaria)
    {
        ValorDiaria = valorDiaria;
        return this;
    }

    public Veiculo SetStatusDisponibilidade(EStatusDisponibilidade statusDisponibilidade)
    {
        StatusDisponibilidade = statusDisponibilidade;
        return this;
    }
}
