/*Задание 4: Замена отрицательных элементов в двумерном массиве
Описание: Задайте двумерный массив. Замените все отрицательные числа на их
абсолютные значения.
Пример входных данных:
1 - 2 3
- 4 5 - 6
7 - 8 9
Пример результата:
1 2 3
4 5 6
7 8 9*/

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


void ChangeNegativesToPositives(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (matrix[i, j] < 0)
          {
            matrix[i, j] = matrix[i, j] * -1;
          }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -3, 10);
PrintMatrix(array2d);

Console.WriteLine();

ChangeNegativesToPositives(array2d);
PrintMatrix(array2d);