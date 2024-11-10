using POO_3;

Pessoa[] pessoas = new Pessoa[3];

for (int i = 0; i < pessoas.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Digite o nome do professor:");
        pessoas[i] = new Professor(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Digite o nome do aluno: ");
        pessoas[i] = new Aluno(Console.ReadLine());
    }
}

for (int i = 0; i < pessoas.Length; i++)
{
    if (i == 0)
    {
        ((Professor)pessoas[i]).Explicar();
    }
    else
    {
        ((Aluno)pessoas[i]).Estudar();
    }
}

