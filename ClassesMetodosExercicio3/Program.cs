Console.WriteLine();

Carro peugeot = new Carro("207", "Peugeot", "Peugeot", 2016, 120);
Console.WriteLine(peugeot.potencia);

peugeot.AumentarPotencia(ref peugeot.potencia);

Console.WriteLine(peugeot.potencia);




Console.ReadKey();
public class Carro
{
    public string? modelo;
    public string? marca;
    public string? montadora;
    public int ano;
    public int potencia;

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

    public double VelocidadeMaxima() => this.potencia * 1.75;

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }
    public int AumentarPotencia(ref int potencia)
    {
        return potencia += 5;
    }

}


