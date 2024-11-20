List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Hugo", "Gustavo", "Pedro"
};

// query syntax
var resultado = from m in nomes
                where m.Contains("o")
                select m;

foreach (var i in resultado)
{
    Console.WriteLine(i);
}

// method syntax
Console.WriteLine("Usando method syntax");
var resultado2 = nomes.Where(m => m.Contains("a"));
foreach (var i in resultado2)
{
    Console.WriteLine(i);
}