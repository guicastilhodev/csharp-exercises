namespace Collections7;

public class Aluno
{
    string[] valor = new string[10];

    public string this[int n]
    {
        get { return (n >= 0 && n < valor.Length) ? valor[n] : "Erro"; }
        set { if (n >= 0 && n < valor.Length) { valor[n] = value; } }
    }

}

