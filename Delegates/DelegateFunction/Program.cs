Console.WriteLine("Informe um double: ");
double num = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = Math.Sqrt;

Console.WriteLine(raizQuadrada(num));

Console.ReadKey();

