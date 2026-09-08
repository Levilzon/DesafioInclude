using System.Data;
using AdministrandoAluguelDeVeiculos.Core.Enums;
using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using FluentValidation;
namespace AdministrandoAluguelDeVeiculos.Application.Validators;

public class VeiculoValidator : AbstractValidator<VeiculoInputModel>
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
            .NotEmpty()
            .WithMessage("Informe o ano do veiculo.");
        RuleFor(c => c.Placa)
            .NotEmpty()
            .WithMessage("Informe o placa do veiculo.");
        RuleFor(c => c.ValorDiaria)
            .NotNull()
            .NotEmpty()
            .WithMessage("Informe o valor do veiculo.");
        
    }
}