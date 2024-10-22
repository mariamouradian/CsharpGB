// Задача 3: 
// Вывод элементов массива в обратном порядке 
// Описание: 
// Задайте произвольный массив. 
// Выведите его элементы, начиная с конца. 
// Используйте рекурсию и не используйте циклы. 
// Пример: 
// ● Вход: {1, 2, 3, 4, 5} 
// ● Выход:5, 4, 3, 2, 1 

// ● Вход: {10, 20, 30, 40} 
// ● Выход:40, 30, 20, 10 

// Заготовка: 
// using System; 
// public class Answer { public static void PrintArrayReverse(int[] array, int index) 
// { // Введите свое решение ниже } 
// static public void Main(string[] args) { int[] array = { 1, 2, 3, 4, 5 }; 
// // Можно поменять значение для проверки Console.WriteLine("Массив в обратном порядке:"); 
// PrintArrayReverse(array, array.Length- 1); } } 

// Подсказка: Используйте рекурсию, чтобы выводить элементы массива начиная с последнего и до первого.

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
        if(i <  array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) return;
    Console.Write(array[index]); 
    if (index > 0) 
    Console.Write(", "); 
    PrintArrayReverse(array, index - 1);

}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);
Console.WriteLine();
PrintArrayReverse(arr, arr.Length - 1);