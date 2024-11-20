// 1) 
//Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
//as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora

//Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
//Exiba os nomes da segunda e da penúltima fruta no console
//Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
//Ordene a coleção de frutas na ordem ascendente
//Exiba no console a coleção de nomes de frutas na ordem inversa

string[] frutas =
    {"Maça",
    "Banana",
    "Laranja",
    "Uva",
    "Manga",
    "Pera",
    "Abacate",
    "Mamao",
    "Pessego",
    "Amora"
    };


for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}

foreach (var i in frutas)
{
    Console.WriteLine(i);
}

Console.WriteLine(frutas.Count());

for (int i = 0; i < frutas.Length; i++)
{
    if (frutas[i] == frutas[1] || frutas[i] == frutas[frutas.Length - 2])
    {
        Console.WriteLine(frutas[i]);
    }
}

frutas[2] = "Kiwi";
frutas[frutas.Length - 1] = "Caqui";
Console.WriteLine(string.Join(" ", frutas));

Array.Sort(frutas);
Console.WriteLine(string.Join(" ", frutas));
Console.WriteLine(string.Join(" ", frutas.Reverse()));