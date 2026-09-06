using AdministrandoAluguelDeVeiculos.Core.Models.InputModels;
using FluentValidation;
using FluentValidation.Validators;

namespace AdministrandoAluguelDeVeiculos.Application.Validators;

public class CadastrarClienteValidator : ClienteBaseValidator<ClienteInputModel>
{
    public CadastrarClienteValidator()
    {
        
    }
}