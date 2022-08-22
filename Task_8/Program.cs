// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int Numbers = 1;

while (Numbers <= N)
{
    if (Numbers%2 == 0) Console.Write($"{Numbers} ");
    Numbers++;
}
