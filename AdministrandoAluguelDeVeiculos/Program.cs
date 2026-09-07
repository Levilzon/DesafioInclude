using AdministrandoAluguelDeVeiculos.Application;
using AdministrandoAluguelDeVeiculos.Infrastructure;
using AdministrandoAluguelDeVeiculos.Extensions;
using AdministrandoAluguelDeVeiculos.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services
    .AddInfrastructure()
    .AddApplication()
    .AddAutoValidators()
    .AddMiddleware();
   

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
        {
            c.DocumentTitle = "API AdmAluguelDeCarros - v1";
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API AdmAluguelDeCarrosV1");
        }
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<GlobalExceptionHandler>();

app.MapControllers();

app.Run();