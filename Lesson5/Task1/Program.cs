﻿/*Задача 1 
• Вычислить факториал от натурального числа N*/

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}
Console.WriteLine(Fact(5));