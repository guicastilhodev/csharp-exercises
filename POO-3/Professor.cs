namespace POO_3
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            this.nome = nome;
        }
        public void Explicar()
        {
            Console.WriteLine($"O professor {nome} está explicando...");
        }
    }
}
