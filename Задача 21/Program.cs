// Программа, которая принимает на вход координаты 2-х точек и находит расстояние между ними.

Console.Clear();

Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double res = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)));

res = Math.Sqrt(res);
res = Math.Round(res,2);

Console.WriteLine($"Расстояние мжду точками А и В: {res}");

