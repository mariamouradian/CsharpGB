﻿// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Указание Использовать рекурсию. 
// Не использовать цикл. 
// Пример N=5 => 1 2 3 4 5

void PrintNaturalNumbers(int num)
{
    if(num == 0) return;
    Console.Write($"{num} "); // вывод в обратном порядке
    PrintNaturalNumbers(num - 1);
    // Console.Write($"{num} "); - вывод в прямом порядке
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(number);
