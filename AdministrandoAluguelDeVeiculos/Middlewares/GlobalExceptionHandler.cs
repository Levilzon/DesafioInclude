using System.Net;
using AdministrandoAluguelDeVeiculos.Core;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;

namespace AdministrandoAluguelDeVeiculos.Middlewares;

public class GlobalExceptionHandler :IMiddleware
{
    private const string  MENSAGEM_PADRAO = "O SERVIDOR SE ENCONTRA COM PROBLEMAS. TENTE NOVAMENTE MAIS TARDE!";

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            
            var mensagemDeErro = Variaveis.Geral.ENV == "prd"
                ? (ex.InnerException?.Message ?? ex.Message ?? MENSAGEM_PADRAO) : MENSAGEM_PADRAO;

            if (context != null)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                
                await context.Response.WriteAsJsonAsync(
                    new RespostasPadraoViewModel(new[] {mensagemDeErro}, false)
                    );
            }
        }  
    
}