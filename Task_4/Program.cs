﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = 0;

if (a > b && a > c)  max = a;
else if (b > a && b > c) max = b;
else if (c > a && c > b) max = c;

Console.WriteLine($"Максимальное число {max}");
