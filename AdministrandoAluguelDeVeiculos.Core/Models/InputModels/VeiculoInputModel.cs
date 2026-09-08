namespace AdministrandoAluguelDeVeiculos.Core.Models.InputModels;

public class VeiculoInputModel
{
        public VeiculoInputModel(string marcaVeiculo, string modeloVeiculo, int ano, string placa, double valorDiaria,
                string statusDisponibilidade)
        {
                MarcaVeiculo = marcaVeiculo;
                ModeloVeiculo = modeloVeiculo;
                Ano = ano;
                Placa = placa;
                ValorDiaria = valorDiaria;
                StatusDisponibilidade = statusDisponibilidade;
        }
        
        public string MarcaVeiculo { get;  }
        
        public string ModeloVeiculo { get; } 

        public int Ano { get; }

        public string Placa { get; }

        public double ValorDiaria { get; }

        public string StatusDisponibilidade { get;  }
    
}
