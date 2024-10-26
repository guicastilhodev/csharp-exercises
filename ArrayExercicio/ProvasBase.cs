public class Provas
{
    public string[] alunos = new string[5];
    public double[] notas = new double[5];

    public void DefineAlunos()
    {
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string? nome = Console.ReadLine();
            alunos[i] = nome;
        }
    }

    public void DefineNotas()
    {
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Digite a nota do aluno: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            notas[i] = nota;
        }
    }


    public void ExibeAlunos()
    {
        foreach (var aluno in alunos)
        {
            Console.Write(aluno);
        }
    }
    public void ExibeNotas()
    {
        foreach (var nota in notas)
        {
            Console.WriteLine(nota);
        }
    }

    public void ExibeMedia()
    {
        double media = 0, soma = 0;
        foreach (var nota in notas)
        {

            soma += nota;

        }
        media = soma / notas.Count();
        Console.WriteLine($"A média da turma é {media}");
    }
}