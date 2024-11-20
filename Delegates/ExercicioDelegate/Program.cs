List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(new Pessoa("Gui", 20));
pessoas.Add(new Pessoa("Joao", 15));
pessoas.Add(new Pessoa("Pedro", 18));
pessoas.Add(new Pessoa("Caio", 16));

Action<Pessoa> imprimeNomeIdade = x => Console.WriteLine($"{x.Nome} - {x.Idade}");
pessoas.ForEach(imprimeNomeIdade);

Console.WriteLine();

Predicate<Pessoa> maiorDeIdade = x => x.Idade >= 18;
var maioresDeIdade = pessoas.FindAll(maiorDeIdade);
maioresDeIdade.ForEach(imprimeNomeIdade);

Console.WriteLine();

Func<Pessoa, int> obterIdade = x => x.Idade;
var pessoaMaisVelha = pessoas.MaxBy(obterIdade);

//int idadeMaxima = pessoas.Max(obterIdade);
//var pessoaMaisVelha = pessoas.Find(x => x.Idade == idadeMaxima);

imprimeNomeIdade(pessoaMaisVelha);

Console.ReadKey();


public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}