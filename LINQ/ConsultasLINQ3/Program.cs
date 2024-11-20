using ConsultasLINQ3;

// Agrupamento - GroupBy
var listaProdutos = Produto.GetProduto();

var produtosPorCategoria = listaProdutos
                            .GroupBy(x => x.Categoria)
                            .OrderBy(x => x.Key)
                            .Select(x => new
                            {
                                Categoria = x.Key,
                                Produtos = x.OrderBy(x => x.Nome)
                                .Select(x => new
                                {
                                    Nome = x.Nome,
                                    Preco = x.Preco,
                                    Estoque = x.Estoque,
                                })

                            });


foreach (var grupo in produtosPorCategoria)
{
    Console.WriteLine($"{grupo.Categoria}");
    Console.WriteLine();
    foreach (var produto in grupo.Produtos)
    {
        Console.WriteLine($"  {produto.Nome} - {produto.Preco:C2}");
        Console.WriteLine();
    }
}

Console.ReadKey();