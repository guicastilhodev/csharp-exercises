using ConsultasLINQ2;

var listaProdutos = Produto.GetProduto();

Console.WriteLine("Localiza o primeiro - First");

var primeiroProduto = listaProdutos.First();
Console.WriteLine($"{primeiroProduto.Nome}");

Console.WriteLine("Localiza o primeiro usando critério de nome");

try
{
    var primeiraCamisa = listaProdutos.First(x => x.Nome.Contains("Camisa"));
    Console.WriteLine(primeiraCamisa.Nome);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Usando FirstOrDefault");

var primeiroEletronico = listaProdutos.FirstOrDefault(x => x.Categoria.Equals("Eletrônicos"));
if (primeiroEletronico != null)
    Console.WriteLine(primeiroEletronico.Nome);
else
    Console.WriteLine("Nenhum elemento encontrado");



Console.ReadKey();

static void ExibeLista(IEnumerable<Produto> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine($"Nome: {item.Nome} - Categoria: {item.Categoria} - Preço: {item.Preco}");
    }
}