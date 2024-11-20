using ConsultasLINQ;

// Localizando por categoria 

var listaProdutos = Produto.GetProduto();


var eletronicos = listaProdutos.Where(x => x.Categoria.Equals("Eletrônicos"));

ExibirLista(eletronicos);


// Localizando por preço menor que 500

var produtosBaratos = listaProdutos
                        .Where(x => x.Preco <= 500);

ExibirLista(produtosBaratos);

// Localizando por produtos caros com estoque superior a 5
Console.WriteLine("Caros e com estoque maior que 5");
var produtosCaros = listaProdutos
                        .Where(x => x.Preco >= 1000 && x.Estoque > 5);

ExibirLista(produtosCaros);

// Filtrando com ordenação
Console.WriteLine("Filtrando produtos com estoque minimo ordenados por nome");
int minimo = 10;
var produtosEstoqueMinimo = listaProdutos
                                .Where(x => x.Estoque < minimo)
                                .OrderBy(x => x.Nome);

ExibirLista(produtosEstoqueMinimo);


Console.ReadKey();

static void ExibirLista(IEnumerable<Produto> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine($"Nome: {item.Nome} - Categoria: {item.Categoria} - Preço: {item.Preco}");
    }
}