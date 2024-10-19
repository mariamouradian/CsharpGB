/*Задание 3: Транспонирование двумерного массива
Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
транспонирует массив (меняет строки и столбцы местами).
Пример входных данных:
1 2
3 4
5 6
Пример результата:
1 3 5
2 4 6*/

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


void TransposeMatrix(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] transposed = new int[cols, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            transposed[j, i] = array[i, j];
        }
    }
    Console.WriteLine("Транспонированный массив:");
    for (int i = 0; i < cols; i++)
    {
        Console.Write("|");
        for (int j = 0; j < rows; j++)
        {
            Console.Write($"{transposed[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

TransposeMatrix(array2d);