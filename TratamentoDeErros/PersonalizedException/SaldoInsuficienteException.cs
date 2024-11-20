namespace PersonalizedException
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string message) : base(message) { }
        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException) { }

        public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"{saque} é maior que o Saldo:{saldo}") { }

        public override string Message
        {
            get
            {
                return "Não existe saldo para o valor do saque";
            }
        }




    }
}
