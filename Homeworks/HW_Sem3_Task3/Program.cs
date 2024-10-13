// Задание 3:
// Поиск среднего значения массива
// Описание: Задайте массив из 10 целых чисел.
// Найдите среднее значение элементов массива.

using System.Diagnostics.CodeAnalysis;

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
double sum = 0;
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
}

for (int i = 0;i < array.Length; i++)
{
    result = sum / array.Length;
}

Console.Write(result);