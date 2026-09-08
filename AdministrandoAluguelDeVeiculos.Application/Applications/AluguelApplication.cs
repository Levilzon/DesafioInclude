using AdministrandoAluguelDeVeiculos.Application.Validators;
using AdministrandoAluguelDeVeiculos.Core.Entities;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Models.ViewModel;
using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using FluentValidation; 

namespace AdministrandoAluguelDeVeiculos.Application.Applications;

public class AluguelApplication : IAluguelApplication
{
    private readonly IVeiculosRepository _veiculoRepository;
    private readonly IClienteRepository _clienteRepository;
    private readonly IAluguelRepository _aluguelRepository;
    private readonly AlugarVeiculoValidator _validator; 

    public AluguelApplication(IVeiculosRepository veiculoRepository, 
        IClienteRepository clienteRepository, 
        IAluguelRepository aluguelRepository, 
        AlugarVeiculoValidator validator)
    {
        _veiculoRepository = veiculoRepository;
        _clienteRepository = clienteRepository;
        _aluguelRepository = aluguelRepository;
        _validator = validator;
    }

    public async Task<Guid?> AlugarVeiculoPorPlacaAsync(string placa, Guid idCliente, DateTime dataInicial, DateTime dataFinal, CancellationToken ct)
    {
        var dadosValidacao = (Placa: placa, ClienteId: idCliente, DataInicial: dataInicial, DataFinal: dataFinal);
        var resultado = await _validator.ValidateAsync(dadosValidacao, ct);

        if (!resultado.IsValid)
        {
            var mensagens = string.Join(" | ", resultado.Errors.Select(e => e.ErrorMessage));
            throw new ValidationException(mensagens);
        }

        var veiculo = await _veiculoRepository.ObterPorPlacaAsync(placa, ct);
        var cliente = await _clienteRepository.ObterPorIdAsync(idCliente, ct);

        if (veiculo is null) return null;
        if (cliente is null) return null;
        
        dataInicial = dataInicial.Date;
        dataFinal = dataFinal.Date;
        
        veiculo.Alugar();

        var aluguel = new Aluguel(cliente.IdCliente, veiculo.IdVeiculo, dataInicial, dataFinal);
        aluguel.VincularClienteEVeiculo(cliente, veiculo);

        await _aluguelRepository.AdicionarAsync(aluguel, ct);
        _veiculoRepository.Atualizar(veiculo);
        await _aluguelRepository.CommitAsync(ct);

        return aluguel.IdAluguel;
    }

    public async Task<AluguelViewModel?> ObterAluguelPorPlacaAsync(string placa, CancellationToken ct)
    {
        var veiculo = await _veiculoRepository.ObterPorPlacaAsync(placa, ct);
        if (veiculo is null) return null;

        var aluguel = await _aluguelRepository.ObterAluguelAtivoPorVeiculoIdAsync(veiculo.IdVeiculo, ct);
        if (aluguel is null) return null;

        return new AluguelViewModel
        {
            IdAluguel = aluguel.IdAluguel,
            IdVeiculo = veiculo.IdVeiculo,
            PlacaVeiculo = veiculo.Placa,
            ModeloVeiculo = veiculo.ModeloVeiculo,
            DataInicial = aluguel.DataInicial,
            DataFinal = aluguel.DataFinal,
            IdCliente = aluguel.Cliente.IdCliente,
            NomeCliente = aluguel.Cliente.ClienteNome,
            SobrenomeCliente = aluguel.Cliente.ClienteSobrenome,
            ContatoCliente = aluguel.Cliente.ClienteContato
        };
    }
}