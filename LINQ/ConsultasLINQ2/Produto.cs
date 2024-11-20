namespace ConsultasLINQ2
{
    public class Produto
    {
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string? Descricao { get; set; }

        public static List<Produto> GetProduto()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Nome = "Smartphone", Categoria = "Eletrônicos", Preco = 1500.00m, Estoque = 25, Descricao = "Smartphone com tela de 6.5 polegadas e 128GB de memória interna." },
                new Produto { Nome = "Notebook", Categoria = "Informática", Preco = 3500.00m, Estoque = 15, Descricao = "Notebook com processador i7, 16GB RAM e SSD de 512GB." },
                new Produto { Nome = "Camisa Polo", Categoria = "Moda", Preco = 89.90m, Estoque = 50, Descricao = "Camisa polo 100% algodão, disponível em várias cores." },
                new Produto { Nome = "Mesa de Jantar", Categoria = "Móveis", Preco = 799.90m, Estoque = 10, Descricao = "Mesa de jantar para 6 pessoas, em madeira maciça." },
                new Produto { Nome = "Café em Grãos", Categoria = "Alimentos", Preco = 29.90m, Estoque = 100, Descricao = "Café especial em grãos, torrado e embalado a vácuo." },
                new Produto { Nome = "Bicicleta Mountain Bike", Categoria = "Esportes", Preco = 2500.00m, Estoque = 8, Descricao = "Bicicleta com suspensão dianteira e 21 marchas." },
                new Produto { Nome = "Fone de Ouvido Bluetooth", Categoria = "Acessórios", Preco = 199.90m, Estoque = 40, Descricao = "Fone de ouvido sem fio com cancelamento de ruído." },
                new Produto { Nome = "Livro de Ficção", Categoria = "Livros", Preco = 39.90m, Estoque = 30, Descricao = "Livro de ficção best-seller, edição de capa dura." },
                new Produto { Nome = "Jogo de Panelas", Categoria = "Utilidades Domésticas", Preco = 499.90m, Estoque = 20, Descricao = "Conjunto de panelas antiaderentes com 5 peças." },
                new Produto { Nome = "Chinelo", Categoria = "Calçados", Preco = 25.90m, Estoque = 70, Descricao = "Chinelo confortável, ideal para o dia a dia." },
                new Produto { Nome = "Chinelo", Categoria = "Calçados", Preco = 25.90m, Estoque = 70, Descricao = "Chinelo confortável, ideal para o dia a dia." }
            };
            return produtos;
        }
    }
}
