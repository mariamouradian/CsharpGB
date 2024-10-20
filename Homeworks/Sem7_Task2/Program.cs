// Задание 1. 
// Рекурсия 
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание Использовать рекурсию. 
// Пример 
// 123 => 6 
// 63 => 9

// int Fact(int n)
// {
//     {
//         if (n == 0 || n == 1)
//         {
//             Console.WriteLine($"Stop: {n}");
//             return 1;
//         }

//     }
//     Console.WriteLine(n);
//     return n * Fact(n - 1);
// }
// Console.WriteLine(Fact(5));

int SumOfDigits(int num) // 123, 12, 1, 0
{
    if (num == 0) return 1;
    return num % 10 + SumOfDigits(num / 10); // 123, 12, 1, 0
    //1%10=1 + 12%10=2 + 123%10=3   1+2+3+0=6
}
Console.WriteLine(SumOfDigits(123));
