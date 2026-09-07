using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using FluentValidation;

namespace AdministrandoAluguelDeVeiculos.Application.Validators;

public class ClienteBaseValidator<T>: AbstractValidator<T> where T: ClienteBaseInputModel
{
    public ClienteBaseValidator()
    {
        RuleFor(c => c.ClienteNome)
            .NotEmpty()
            .WithMessage("Informe o seu primeiro nome.");
        RuleFor(c => c.ClienteSobrenome)
            .NotEmpty()
            .WithMessage("Informe seu sobrenome.");
        RuleFor(c => c.ClienteEmail)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Informe o seu e-mail.");

        RuleFor(c => c.ClienteContato)
            .NotEmpty()
            .WithMessage("Informe o seu número de telefone.");

    }
}