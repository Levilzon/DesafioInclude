using AdministrandoAluguelDeVeiculos.Core.Enums;

namespace AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

public class VeiculoAtualizarInputModel : VeiculoInputModel
{
    public VeiculoAtualizarInputModel(string marcaVeiculo, string modeloVeiculo, int ano, string placa,
        double valorDiaria, EStatusDisponibilidade statusDisponibilidade) : base(marcaVeiculo, modeloVeiculo, ano, placa, valorDiaria, statusDisponibilidade)

    {

    }
}