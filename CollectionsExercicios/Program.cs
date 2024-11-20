// 1 

//string[] frutas =
//    {"Maça",
//    "Banana",
//    "Laranja",
//    "Uva",
//    "Manga",
//    "Pera",
//    "Abacate",
//    "Mamao",
//    "Pessego",
//    "Amora"
//    };


//for (int i = 0; i < frutas.Length; i++)
//{
//    Console.WriteLine(frutas[i]);
//}

//foreach (var i in frutas)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(frutas.Count());

//for (int i = 0; i < frutas.Length; i++)
//{
//    if (frutas[i] == frutas[1] || frutas[i] == frutas[frutas.Length - 2])
//    {
//        Console.WriteLine(frutas[i]);
//    }
//}

//frutas[2] = "Kiwi";
//frutas[frutas.Length - 1] = "Caqui";
//Console.WriteLine(string.Join(" ", frutas));

//Array.Sort(frutas);
//Console.WriteLine(string.Join(" ", frutas));
//Console.WriteLine(string.Join(" ", frutas.Reverse()));

// 2 

//Console.WriteLine("Digite o tamanho do array: ");
//int tamanhoArray = Convert.ToInt32(Console.ReadLine());
//Random random = new Random();

//int[] numeros = new int[tamanhoArray];

//for (int i = 0; i < numeros.Length; i++)
//{
//    numeros[i] = random.Next(1, 51);
//}

//string? readValue;
//do
//{
//    Console.WriteLine("Digite um número a ser buscado");
//    readValue = Console.ReadLine();
//    if (readValue != null)
//    {
//        int.TryParse(readValue, out var val);
//        Console.WriteLine(numeros.Contains(val) ? "SIM" : "NÃO");
//    }

//} while (readValue != "fim");


//float[,] notas = new float[2, 5];


//for (int i = 0; i < notas.GetLength(0); i++)
//{
//    Console.WriteLine($"Grupo {i}");
//    for (int j = 0; j < notas.GetLength(1); j++)
//    {
//        Console.WriteLine($"Digite a nota {j}");
//        notas[i, j] = float.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine("---------------------------");
//for (int i = 0; i < notas.GetLength(0); i++)
//{
//    float sumNotas = 0;
//    for (int j = 0; j < notas.GetLength(1); j++)
//    {
//        sumNotas += notas[i, j];
//    }
//    float media = sumNotas / notas.GetLength(1);
//    Console.WriteLine($"Média do grupo {i}: {media} ");
//}


//using System.Collections;

//var lista = new ArrayList();

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Nome: ");
//    string? nome = Console.ReadLine();
//    Console.WriteLine("Idade: ");
//    int idade = Convert.ToInt32(Console.ReadLine());

//    lista.Add(new Pessoa()
//    {
//        Nome = nome,
//        Idade = idade,
//    });
//}
//ListaPessoas(lista);

//Console.WriteLine("------------");

//Pessoa gui = new Pessoa() { Nome = "gui", Idade = 20 };
//Pessoa paulo = new Pessoa() { Nome = "paulo", Idade = 50 };

//lista.Add(gui);
//lista.Add(paulo);

//ListaPessoas(lista);

//lista.RemoveAt(lista.Count - 1);

//Console.WriteLine("---------------");

//ListaPessoas(lista);


//Console.ReadKey();

//static void ListaPessoas(ArrayList lista)
//{
//    foreach (Pessoa p in lista)
//    {
//        p.Exibir();
//    }
//}

//public class Pessoa
//{
//    public string? Nome { get; set; }
//    public int Idade { get; set; }

//    public void Exibir()
//    {
//        Console.WriteLine($"Nome: {Nome}");
//        Console.WriteLine($"Idade: {Idade}");
//    }
//}


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

