
Carro celta = new("Celta", "Chevrolet");
celta.potencia = 200;
Console.WriteLine(celta.VelocidadeMaxima(celta.potencia));

Console.ReadKey();

public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public Carro(string? Modelo, string? Montadora)
    {
        modelo = Modelo;
        montadora = Montadora;
    }

    public double VelocidadeMaxima(int potencia) => potencia * 1.75;

}