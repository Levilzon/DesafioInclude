Primeiro execute o script do banco de dados em seu SGBD para ter o conjunto de tabelas que foram utilizadas.
Alguns códigos estão lá porque ocorreram alterações em determinadas linhas.

Após isso configure o endereço do banco de dados no seguinte diretório:

AdministrandoAluguelDeVeiculos.Infrastructure;

Assim que abrir, você encontrará uma classe chamada InfrastructureModel. Nela terá um único método com o seguinte segmento:
 
services.AddDbContext<AdministrandoAluguelDeVeiculosContext>(p =>
          p.UseNpgsql("Server=localhost;Port=5432;Database=administrando_aluguel_veiculos;User Id={usuario};Password={senha}"));

No texto entre parênteses, caso seu postgres esteja com os valores padrão para as variáveis Server e Port, 
não á o que alterar. 
Já na parte: 

User Id={usuario}

Password={senha}

Apague as chaves junto com a expressão interna delas, e coloque o usuário que você utiliza mais a sua senha.
