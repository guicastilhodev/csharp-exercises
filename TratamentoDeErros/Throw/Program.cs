
A.ProcessarA();

public class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();

        }
        catch (Exception)
        {
            Console.WriteLine("Tratando em A");
        }
    }
}
public class B
{
    public static void ProcessarB()
    {
        try
        {

            C.ProcessarC();
        }
        catch (Exception)
        {
            throw;
        }
    }
}

public class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}
