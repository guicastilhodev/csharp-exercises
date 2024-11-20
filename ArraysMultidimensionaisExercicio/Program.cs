string[,] alunos = new string[2, 5];


for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"{i} {j} -  Aluno: ");
        var aluno = Console.ReadLine();
        alunos[i, j] = aluno;
    }
}

foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
    Console.WriteLine();
}


Console.ReadKey();


