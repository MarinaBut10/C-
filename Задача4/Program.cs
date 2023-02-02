// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите число x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число y: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число z: ");
int z = int.Parse(Console.ReadLine());

if (x > y && x > z) Console.WriteLine($"Макс.число {x}");
if (y > x && y > z) Console.WriteLine($"Макс.число {y}");
if (z > y && z > x) Console.WriteLine($"Макс.число {z}");
if (x == y && y== z && x == z) Console.WriteLine("Числа равны друг другу");