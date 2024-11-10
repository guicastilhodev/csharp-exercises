namespace POO_3
{
    public class Pessoa
    {
        public string nome;
        public Pessoa(string nome)
        {
            this.nome = nome;
        }
        public override string ToString()
        {
            return "Meu nome é " + nome;
        }
    }
}