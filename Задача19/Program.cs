// Задача 19_
// 

Console.Clear();

Console.WriteLine("Введите 5-значное число: ");

int num = int.Parse(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    if((num / 10000 == num % 10) && (num / 1000 % 10 == num % 100 / 10))
    {
       Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }  
}    
else
{
Console.WriteLine($"Число {num} не 5-значное");
}

