using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Core.Mappers;

public static class VeiculoMapper
{
    public static VeiculoViewModel ToViewModel(this Veiculo veiculo)
    {

        return new VeiculoViewModel(
            veiculo.IdVeiculo,
            veiculo.MarcaVeiculo,
            veiculo.ModeloVeiculo,
            veiculo.Ano,
            veiculo.Placa,
            veiculo.ValorDiaria,
            veiculo.StatusDisponibilidade
        );
    }
}