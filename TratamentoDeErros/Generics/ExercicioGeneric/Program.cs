
int[] numbers = { 1, 2, 3, 4, 5 };

double[] result = { 1.5, 2.0, 4.5 };

string[] names = { "Gui", "Caio", "Gu" };

Exemplo.ReverterEImprimir(numbers);
Exemplo.ReverterEImprimir(result);
Exemplo.ReverterEImprimir(names);




Console.ReadKey();

public class Exemplo
{
    public static void ReverterEImprimir<T>(T[] obj)
    {
        Array.Reverse(obj);
        foreach (var item in obj)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}