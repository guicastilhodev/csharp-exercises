
using PersonalizedException;

Conta conta = new Conta(100, "Gui", 1000m);

try
{
    Console.WriteLine(conta.ToString());

    conta.Depositar(100);

    Console.WriteLine(conta.Saldo);

    conta.Sacar(5000);

    Console.WriteLine(conta.Saldo);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}







Console.ReadKey();

public class Conta
{
    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        if (Saldo < valor)
        {
            throw new SaldoInsuficienteException(valor, Saldo);
        }
        Saldo -= valor;
        return Saldo;
    }

    public override string ToString()
    {
        return $"Conta: {Numero} : {Titular} - Saldo:{Saldo:c}";
    }

}
