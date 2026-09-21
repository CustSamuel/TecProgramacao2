/* Considere uma lista de pessoas, sendo os dados de pessoa: Nome, Idade.
 * Utilizando delegates pré-definidos resolva as funcionalidades abaixo:
 * 1- Percorrer a lista de pessoas e mostrar os nomes e idades; // ACTION
 * 2- Filtrar a lista, retornando os maiores de 18 anos. // PREDICATE 
 * 3- Mostrar o nome e idade da pessoa mais velha da lista. // FUNC
 * 
 */

using System.Security.Cryptography.X509Certificates;

var ListaDePessoas = Pessoa.getPessoas();
Console.WriteLine("Item 1");
//definição

Action<Pessoa> MostrarPessoas = p => Console.WriteLine($"Nome = {p.Nome} - {p.Idade}");
//uso

//forEach é um método da classe List e faz o mesmo que foreach tradicional
ListaDePessoas.ForEach(MostrarPessoas);
//sem delegate
ListaDePessoas.ForEach(p=> Console.WriteLine($"Nome = {p.Nome} - {p.Idade}"));

Console.WriteLine("");

Console.WriteLine("Item 2");
//definição
Predicate<Pessoa> ehMaior18 = p => p.Idade > 18;
//uso
//O predicate retorna true caso a pessoa tenha mais de 18 anos, e falso caso contrário.
//FindAll caso o retorno seja true seleciona a pessoa
var maior18 = ListaDePessoas.FindAll(ehMaior18);
maior18.ForEach(MostrarPessoas);

Console.WriteLine("");

Console.WriteLine("Item 3");
//definição
Func<Pessoa, int> ObterIdade = p => p.Idade;
//uso
/* O delegate ObterIdade retorna a idade de cada pessoa da lista.
 * O MaxBy guarda na memória a idade maior na memória, comparando uma a uma. Quando acaba a lista retorna o objeto pessoa.
 */
var maisVelho = ListaDePessoas.MaxBy(ObterIdade);
Console.WriteLine($"Nome: {maisVelho.Nome} - Idade: {maisVelho.Idade}");







Console.ReadKey();

public class Pessoa

{
    public Pessoa (string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public static List<Pessoa> getPessoas()
    {
        List<Pessoa> ListaPessoas = new List<Pessoa>();
        ListaPessoas.Add(new Pessoa("Marta", 17));
        ListaPessoas.Add(new Pessoa("Lucas", 24));
        ListaPessoas.Add(new Pessoa("Camila", 31));
        ListaPessoas.Add(new Pessoa("Bruno", 19));
        ListaPessoas.Add(new Pessoa("Amanda", 45));
        ListaPessoas.Add(new Pessoa("Rafael", 12));
        ListaPessoas.Add(new Pessoa("Beatriz", 28));
        ListaPessoas.Add(new Pessoa("Thiago", 50));
        ListaPessoas.Add(new Pessoa("Larissa", 8));
        ListaPessoas.Add(new Pessoa("Rodrigo", 37));

        return ListaPessoas;

    }

     public string Nome { get; set; }
     public int Idade { get; set; }

}
