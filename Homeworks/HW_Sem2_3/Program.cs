// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
Console.Write("Введите целое число от 10 до 99: ");
int a = Convert.ToInt32(Console.ReadLine());

if  (a >= 10 || a <= 99)
{
    int firstNumber = a / 10;
    int secondNumber = a % 10;

    if (firstNumber > secondNumber)
    {
        Console.Write(firstNumber);
    }
    else
    {
        Console.Write(secondNumber);
    }
}
else
{
    Console.Write("Введенное число вне заданного диапазона.");
}