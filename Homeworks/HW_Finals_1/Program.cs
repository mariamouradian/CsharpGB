// Задача 1: 
// Вывод натуральных чисел в промежутке от M до N 

// Описание: 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Используйте рекурсию и не используйте циклы. 
// Пример: 
// Вход: M = 1, N = 5 
// Выход:1, 2, 3, 4, 5

// Вход: M = 4, N = 8 
// Выход:4, 5, 6, 7, 8 

// Заготовка: 
// using System; public class Answer 
// { public static void PrintRange(int M, int N) 
// { // Введите свое решение ниже } 
// static public void Main(string[] args) { int M = 1; 
// // Можно поменять значение для проверки int N = 5; 
// // Можно поменять значение для проверки Console.WriteLine("Числа в промежутке:"); PrintRange(M, N); } }


void PrintRange(int m, int n)
{
    // if (m - n < 0)
    // {
        if (m > n) return;
        Console.Write(m);
        if (m < n) Console.Write(", ");
        PrintRange(m+1, n);
    // }
    // if (m - n > 0)
    // {
    //     if (n > m) return;
    //     Console.Write(n);
    //     if (n < m) Console.Write(", ");
    //     PrintRange(m, n-1);
    // }

}

// Console.WriteLine("Введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());

int m = 1;
int n = 15;
Console.WriteLine("Числа в промежутке:"); 
PrintRange(m, n);