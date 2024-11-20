Console.WriteLine();

Carro peugeot = new Carro("207", "Peugeot", "Peugeot", 1892, 120);
peugeot.ExibirInfo(peugeot.modelo, peugeot.montadora, peugeot.marca, peugeot.potencia, peugeot.ano);

Console.ReadKey();
public class Carro
{
    public string? modelo;
    public string? marca;
    public string? montadora;
    public int potencia;
    private static double valorIpva;
    private int Ano;
    public int ano
    {
        get { return Ano; }
        set
        {
            if (Ano < 2000)
                Ano = 2000;

            else if (Ano > 2022)
                Ano = 2022;

            else
                Ano = value;
        }
    }


    public Carro(string? modelo, string? marca, string? montadora, int ano, int potencia)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.montadora = montadora;
        this.ano = ano;
        this.potencia = potencia;
    }

    public Carro(string? modelo, string? montadora)
    {
        this.modelo = modelo;
        this.montadora = montadora;
    }

    static Carro()
    {
        valorIpva = 4;
    }

    public double VelocidadeMaxima() => this.potencia * 1.75;

    public int AumentarPotencia(ref int potencia)
    {
        return potencia += 5;
    }

    public int AumentarPotenciaVelocidade(ref int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;

    }

    public void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int ano = 0)
    {
        Console.WriteLine($"Modelo {modelo}\nMontadora {montadora}\nMarca {marca}\nPotencia {potencia}\nAno {ano}");
    }
}


