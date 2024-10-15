﻿// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Пример
// 2 3 4 3
// 4 3 4 1
// 2 9 5 4
//
// =>
//
// 2 + 3 + 5 = 10

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

int SumMainDiagonale(int[,] matrix)
{
    int sum = 0;

    /*int minSize = matrix.GetLength(0);
    if (matrix.GetLength(1) < minSize)
    {
        minSize = matrix.GetLength(1);
    }*/

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}


int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

int result = SumMainDiagonale(array2d);
Console.WriteLine(result);
