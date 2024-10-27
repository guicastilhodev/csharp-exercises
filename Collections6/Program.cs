//Crie um programa C# e defina um método chamado ProcessaObjetos que possa receber um número
//variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto ( Use o método
//GetType () herdado de Object ) no console

ProcessaObjetos(1, "Gui", 3.45m, new Teste(), null);

Console.ReadKey();
static void ProcessaObjetos(params object[] args)
{
    Console.WriteLine("Valor dos objetos: ");

    if (args != null)
    {
        foreach (var arg in args)
        {
            Console.WriteLine($"Nome: {arg}\t Tipo: {arg?.GetType()}");
        }
    }
}

class Teste
{ }


