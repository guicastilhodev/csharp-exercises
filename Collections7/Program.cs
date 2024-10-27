//Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo 10 elementos.
// Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado.

using Collections7;

Aluno aluno = new Aluno();

aluno[0] = "Guilherme";
aluno[1] = "Caio";
aluno[2] = "Joao";
aluno[3] = "Maria";
aluno[4] = "Leonardo";
aluno[5] = "Marcelo";
aluno[6] = "Fabio";
aluno[7] = "Julia";
aluno[8] = "Pietro";
aluno[9] = "Valentina";

string valor1 = aluno[0];
string valor2 = aluno[1];
string valor3 = aluno[2];
string valor4 = aluno[3];
string valor5 = aluno[4];
string valor6 = aluno[5];
string valor7 = aluno[6];
string valor8 = aluno[7];
string valor9 = aluno[8];
string valor10 = aluno[9];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);
Console.WriteLine(valor7);
Console.WriteLine(valor8);
Console.WriteLine(valor9);
Console.WriteLine(valor10);

Console.ReadKey();





