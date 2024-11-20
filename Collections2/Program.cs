//2) Crie um programa em C# que sirva para pesquisar um array de valores inteiros.
// a) Solicite via teclado o número de valores do array deve ser um número inteiro
// b) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
// c) Solicite ao usuário um valor de um número inteiro a procurar no array
// d) Exiba se o número informado existe no array de inteiros ou não
// e) Repita até que o texto ‘fim’ seja inserido via teclado


Console.WriteLine("Digite o tamanho do array: ");
int tamanhoArray = Convert.ToInt32(Console.ReadLine());
Random random = new Random();

int[] numeros = new int[tamanhoArray];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = random.Next(1, 51);
}

string? readValue;
do
{
    Console.WriteLine("Digite um número a ser buscado");
    readValue = Console.ReadLine();
    if (readValue != null)
    {
        int.TryParse(readValue, out var val);
        Console.WriteLine(numeros.Contains(val) ? "SIM" : "NÃO");
    }

} while (readValue != "fim");