// Задача 2: 
// Функция Аккермана 
// Описание: Напишите программу для вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// Пример: 
// ● Вход: m = 2, n = 3 
// ● Выход:A(m, n) = 29 

// ● Вход: m = 1, n = 4 
// ● Выход:A(m, n) = 7 

// Заготовка: 
// using System; 
// public class Answer { public static int Ackermann(int m, int n) 
// {// Введите свое решение ниже } 
// static public void Main(string[] args) { int m = 2; 
// // Можно поменять значение для проверки int n = 3; 
// // Можно поменять значение для проверки int result = Ackermann(m, n); 
// Console.WriteLine($"A({m}, {n}) = {result}"); } } 
// Подсказка: 
// Реализуйте рекурсивную функцию Аккермана, основываясь на её определении: 
// ● A(0,n)=n+1A(0, n) = n + 1A(0,n)=n+1 
// ● A(m,0)=A(m−1,1)A(m, 0) = A(m- 1, 1)A(m,0)=A(m−1,1) 
// ● A(m,n)=A(m−1,A(m,n−1))A(m, n) = A(m- 1, A(m, n- 1))A(m,n)=A(m−1,A(m,n−1))

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Ackermann (int m, int n)
{
    if (m == 0) return n + 1; 
    else if (n == 0) 
    return Ackermann(m - 1, 1); 
    else 
    return Ackermann(m - 1, Ackermann(m, n- 1)); 
}
int n = 4;
int m = 1;
int result = Ackermann(m, n);
Console.WriteLine(result);