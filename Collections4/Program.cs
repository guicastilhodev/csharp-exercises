// 4) Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas.

// a) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades ( nome e idade ) e um método Exibir ()
//para imprimir o nome e a idade;
// b) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
//armazenando as informações na ArrayList.
// c) A seguir exiba no console a lista das pessoas com nome e idade
// d) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
// e) Remova o último elemento da coleção e exiba a lista completa

var produtos = new List<Produto>();

Produto clips = new Produto() { Nome = "Clips", Preco = 3.95m };
Produto caneta = new Produto() { Nome = "Caneta", Preco = 5.99m };
Produto lapis = new Produto() { Nome = "Lapis", Preco = 4.15m };
Produto estojo = new Produto() { Nome = "Estojo", Preco = 6.99m };
Produto caderno = new Produto() { Nome = "Caderno", Preco = 7.55m };

produtos.Add(clips);
produtos.Add(caneta);
produtos.Add(lapis);
produtos.Add(estojo);
produtos.Add(caderno);


Console.ReadKey();


ExibeInfo(produtos);

produtos.Add(new Produto() { Nome = "Mochila", Preco = 22.44m });

Console.WriteLine("-----------------");
ExibeInfo(produtos);

var produtosOrdenados = produtos.OrderBy(x => x.Nome).ToList();
Console.WriteLine("----------------ORDENADOS---------");
ExibeInfo(produtosOrdenados);

var produtosMenorQue5 = produtos.FindAll(x => x.Preco < 5.0m);

ExibeInfo(produtosMenorQue5);

Console.WriteLine(produtos.FindIndex(x => x.Nome.Equals("Estojo")));


static void ExibeInfo(List<Produto> produtos)
{
    decimal somaPreco = 0, media;
    foreach (Produto produto in produtos)
    {
        Console.WriteLine($"Nome: {produto.Nome}\tPreço: {produto.Preco:c}");
        somaPreco += produto.Preco;
    }

    media = somaPreco / produtos.Count();
    Console.WriteLine($"Média = {media:c}");
    Console.WriteLine($"Quantidade = {produtos.Count()}");

}

public class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }

}
