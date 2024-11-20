

try
{
    Console.WriteLine("Informe o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);

    Console.WriteLine($"{dividendo} / {divisor} : {resultado}");
}
catch (FormatException)
{
    Console.WriteLine("Informe um valor inteiro");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Não é possivel dividir por 0");
}
catch (OverflowException)
{
    Console.WriteLine("Informe um valor inteiro entre 1 e 999999");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


Console.ReadKey();