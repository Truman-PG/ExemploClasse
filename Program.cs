using ExemploClasse;

Console.WriteLine("Exemplo de list<Classe>");
Console.WriteLine();
 
//Criando objetos para receber dados de pessoas
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Heitor";
pessoa1.Cpf = 123;

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Dorival";
pessoa2.Cpf = 1234;

//Adicionando dados do tipo pessoa no nosso List<Pessoa> da classe de repositório
PessoaRepository.Pessoas.Add(pessoa1);
PessoaRepository.Pessoas.Add(pessoa2);

//Imprimindo os dados de List<Pessoa> da classe repositorio
foreach(var pessoa in PessoaRepository.Pessoas)
{
    Console.WriteLine($"Nome: {pessoa.Nome} | CPF: {pessoa.Cpf}");
}

//Removendo dados do repositório
PessoaRepository.Pessoas.Remove(pessoa1);

foreach (var pessoa in PessoaRepository.Pessoas)
{
    Console.WriteLine($"Nome: {pessoa.Nome} | CPF: {pessoa.Cpf}");
}