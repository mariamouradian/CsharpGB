// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string CreateStringFrom2DArray(char[,] array)
{
    string res = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
        }
    }
    return res;
}

char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' } };
string result = CreateStringFrom2DArray(charArray);
Console.WriteLine(result);