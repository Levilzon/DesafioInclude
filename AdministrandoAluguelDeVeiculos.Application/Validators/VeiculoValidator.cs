using System.Data;
using AdministrandoAluguelDeVeiculos.Core.Enums;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using FluentValidation;
namespace AdministrandoAluguelDeVeiculos.Application.Validators;

public class VeiculoValidator<T> :AbstractValidator<T> where T :VeiculoInputModel
{
    public VeiculoValidator()
    {
        RuleFor(c => c.MarcaVeiculo)
            .NotEmpty()
            .WithMessage("Informe a marca do veículo.");
        RuleFor(c => c.ModeloVeiculo)
            .NotEmpty()
            .WithMessage("Informe o modelo do veiculo.");
        RuleFor(c => c.Ano)
            .NotNull()
            .WithMessage("Informe o ano do veiculo.");
        RuleFor(c => c.Placa)
            .NotEmpty()
            .WithMessage("Informe o placa do veiculo.");
        RuleFor(c => c.ValorDiaria)
            .NotNull()
            .WithMessage("Informe o valor do veiculo.");
        
    }
}