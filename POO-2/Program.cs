
using POO_2;

LivroFotos livro = new();
Console.WriteLine(livro.GetNumeroPaginas());

LivroFotos livro2 = new(24);
Console.WriteLine(livro2.GetNumeroPaginas());

SuperLivroFotos livro3 = new();
Console.WriteLine(livro3.GetNumeroPaginas());


