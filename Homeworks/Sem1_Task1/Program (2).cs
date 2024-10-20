﻿// Задание1:
// Поиск максимального элемента в каждой строке
// Описание:
// Задайте двумерный массив целых чисел. Напишите программу, которая находит максимальный элемент в каждой строке
// массива и выводит его.
// Пример входных данных:
// 1    3   5   7
// 2    4   6   8
// 9    10  11  12
//
// Пример результата:
// Максимальный элемент в строке 0: 7
// Максимальный элемент в строке 1: 8
// Максимальный элемент в строке 2: 12


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 3x4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max); // () - аргумент
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine(" |");
    }

}





int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();