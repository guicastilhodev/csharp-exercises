// 3) Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
//alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
//seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).

float[,] notas = new float[2, 5];

for (int i = 0; i < notas.GetLength(0); i++)
{
    Console.WriteLine($"Grupo {i}");
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        Console.WriteLine($"Digite a nota {j}");
        notas[i, j] = float.Parse(Console.ReadLine());
    }
}

Console.WriteLine("---------------------------");

for (int i = 0; i < notas.GetLength(0); i++)
{
    float sumNotas = 0;
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        sumNotas += notas[i, j];
    }
    float media = sumNotas / notas.GetLength(1);
    Console.WriteLine($"Média do grupo {i}: {media} ");
}
