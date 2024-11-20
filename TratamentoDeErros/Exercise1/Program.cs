string value = null;

try
{
    Console.WriteLine("Digite um valor: ");
    value = Console.ReadLine();

    if (value == null)
    {
        throw new ArgumentNullException("A entrada não pode ser nula");
    }
    else if (string.IsNullOrWhiteSpace(value))
    {
        throw new ArgumentException("A entrada não pode estar vazia");
    }
    else
    {
        Console.WriteLine(value);
    }

}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();
