namespace POO_3
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            this.nome = nome;
        }

        public void Estudar()
        {
            Console.WriteLine($"O aluno {nome} está estudando");
        }
    }
}
