namespace POO_1
{
    public class Carro : IVeiculo
    {
        public int quantidadeGasolina { get; set; }
        public Carro(int quantidadeGasolina)
        {
            this.quantidadeGasolina = quantidadeGasolina;
        }
        public bool Abastecer(int quantidade)
        {
            quantidadeGasolina += quantidade;
            return true;
        }

        public void Dirigir()
        {
            if (quantidadeGasolina > 0)
            {
                Console.WriteLine("Dirigindo o carro...");
            }
            else
            {
                Console.WriteLine("Sem gasolina");
            }
        }
    }
}
