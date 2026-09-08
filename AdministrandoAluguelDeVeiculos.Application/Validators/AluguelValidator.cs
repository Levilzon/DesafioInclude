using FluentValidation;

namespace AdministrandoAluguelDeVeiculos.Application.Validators;

public class AlugarVeiculoValidator : AbstractValidator<(string Placa, Guid ClienteId, DateTime DataInicial, DateTime DataFinal)>
{
    public AlugarVeiculoValidator()
    {
        RuleFor(x => x.Placa)
            .NotEmpty().WithMessage("A placa é obrigatória.")
            .Length(7, 10).WithMessage("A placa deve ter entre 7 e 10 caracteres.");

        RuleFor(x => x.ClienteId)
            .NotEmpty().WithMessage("O ID do cliente é obrigatório.")
            .NotEqual(Guid.Empty).WithMessage("O ID do cliente é inválido.");

        RuleFor(x => x.DataInicial)
            .NotEmpty().WithMessage("A data inicial é obrigatória.")
            .Must(BeAValidDate).WithMessage("A data inicial é inválida.");

        RuleFor(x => x.DataFinal)
            .NotEmpty().WithMessage("A data final é obrigatória.")
            .Must(BeAValidDate).WithMessage("A data final é inválida.");

        RuleFor(x => x)
            .Must(x => x.DataFinal > x.DataInicial)
            .WithMessage("A data final deve ser maior que a data inicial.");
    }

    private bool BeAValidDate(DateTime date)
    {
        return date != default;
    }
}