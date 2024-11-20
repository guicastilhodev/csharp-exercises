
Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegatePar = x => x % 2 == 0;

if (delegatePar(numero))
    Console.WriteLine("Número par");
else
    Console.WriteLine("Impar");

Console.ReadKey();



