using AdministrandoAluguelDeVeiculos.Application.Validators;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Results;

namespace AdministrandoAluguelDeVeiculos.Extensions;

public static class ValidationExtension
{
    public static IServiceCollection AddAutoValidators(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation(config =>
        {
            config.OverrideDefaultResultFactoryWith<CustomResultFactory>();
        });

        services.AddValidatorsFromAssemblyContaining<CadastrarClienteValidator>();

        return services;
    }

    public class CustomResultFactory : IFluentValidationAutoValidationResultFactory
    {
        public Task<IActionResult?> CreateActionResult(
            ActionExecutingContext context,
            ValidationProblemDetails validationProblemDetails,
            IDictionary<IValidationContext, ValidationResult> validationResults)
        {
            var errors = context.ModelState
                .Where(ms => ms.Value != null && ms.Value.Errors.Any())
                .SelectMany(ms => ms.Value!.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();

            if (!errors.Any())
            {
                errors = validationResults
                    .SelectMany(vr => vr.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
            }

            var response = new RespostasPadraoViewModel(errors, sucesso: false);

            return Task.FromResult<IActionResult?>(new BadRequestObjectResult(response));
        }
    }
}