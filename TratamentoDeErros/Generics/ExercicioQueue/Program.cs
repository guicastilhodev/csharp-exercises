

Queue<string> fila = new Queue<string>();

fila.Enqueue("file1.pdf");
fila.Enqueue("file2.pdf");
fila.Enqueue("file3.pdf");
fila.Enqueue("file4.pdf");

while (fila.Count > 0)
{
    string file = fila.Dequeue();
    Console.WriteLine($"\n{file} está sendo impresso...");
    Thread.Sleep(3000);
    Console.WriteLine($"{file} foi impresso com sucesso!");

}