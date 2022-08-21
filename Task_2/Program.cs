// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int max = 0;
int min = 0;

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    max = a;
    min = b;
    
    Console.WriteLine($"Максимальное число {max}, минимальное {min}");
}
else
{
    min = a;
    max = b;

    Console.WriteLine($"Максимальное число {max}, минимальное {min}");
}   
