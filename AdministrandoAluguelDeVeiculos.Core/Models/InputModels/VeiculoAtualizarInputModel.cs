
namespace AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

public class VeiculoAtualizarInputModel : VeiculoInputModel
{
    public VeiculoAtualizarInputModel(string marcaVeiculo, string modeloVeiculo, int ano, string placa,
        double valorDiaria, string statusDisponibilidade) : base(marcaVeiculo, modeloVeiculo, ano, placa, valorDiaria, statusDisponibilidade)

    {

    }
}