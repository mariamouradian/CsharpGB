﻿// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму.
// Если первое число некратно второму, то программа выводит остаток от деления.
// Примеры 14, 5 => нет, 4
// 16, 8 => да
// 4, 3  => нет, 1

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b != 0)
{
    int c = a % b;
    Console.Write("нет, " + c);
}
else
{
    Console.Write("да");
}
    