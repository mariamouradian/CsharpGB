// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max); // () - аргумент
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void RevertArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp;
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    foreach (int temp in array)
    {
       Console.Write(temp + " ");
    }
}

Console.WriteLine("Задайте размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(a, 100, 1000);
PrintArray(arr);
Console.WriteLine(" ");
Console.Write("Перевернутый массив: ");
RevertArray(arr);
Console.WriteLine(arr);