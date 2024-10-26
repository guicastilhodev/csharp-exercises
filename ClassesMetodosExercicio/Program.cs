using System;

Console.WriteLine("Exercicios ");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Acelerar();
chevrolet.IdadeCarro();

Carro ford = new Carro("SUV", "Ford", "Ecosport", 2018, 120);
ford.Acelerar();
ford.IdadeCarro();

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

    public void Acelerar()
    {
        Console.WriteLine($"{this.marca} está acelerando...");
    }

    public void IdadeCarro()
    {
        Console.WriteLine($"O carro foi lançado a {DateTime.Now.Year - this.ano} anos");
    }
}

