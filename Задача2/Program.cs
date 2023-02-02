// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int max, min;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
    Console.WriteLine($"Максимальное число {max}, минимальное число {min}");
}
