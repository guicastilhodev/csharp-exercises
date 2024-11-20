string nome = null;
int idade = 0;

try
{

    Console.WriteLine("Idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade < 0)
    {
        throw new ArgumentException("Idade negativa");
    }
    else if (idade == 0)
    {
        throw new NotImplementedException("Idade indefinida");
    }

    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nome))
    {
        throw new NullReferenceException("Nome não pode ser nulo e nem vazio");
    }

}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch (NotImplementedException e)
{
    Console.WriteLine(e.Message);
}
catch (NullReferenceException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("ERRO INESPERADO: " + e.Message);
}