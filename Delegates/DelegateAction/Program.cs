Console.WriteLine("Informe um int");
int numero = Convert.ToInt32(Console.ReadLine());


Action<int> delegateDuplicar = x => Console.WriteLine(x * 2);

delegateDuplicar(numero);

Console.ReadKey();