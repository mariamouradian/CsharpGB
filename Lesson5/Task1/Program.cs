/*Задача 1 
• Вычислить факториал от натурального числа N*/

int Fact(int n)
{
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}
Console.WriteLine(Fact(5));

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить