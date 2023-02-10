// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов от 1 до N.

Console.Clear();

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int i = 1;

while(i <= N)
{
    Console.Write(i*i*i);
    if(i !=N)
    {
        Console.Write(", ");
    }
    i++;
}

