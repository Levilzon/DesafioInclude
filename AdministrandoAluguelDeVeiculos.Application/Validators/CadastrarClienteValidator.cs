using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using FluentValidation;
using FluentValidation.Validators;

namespace AdministrandoAluguelDeVeiculos.Application.Validators;

public class CadastrarClienteValidator : AbstractValidator<ClienteInputModel>
{
    public CadastrarClienteValidator()
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