Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber == 0)
{
    Console.Write("На ноль делить нельзя!");
}
else if (firstNumber % secondNumber == 0)
{
    Console.Write("Первое число делится на второе без остатка.");
}
else
{
    Console.Write("Первое число не делится на второе без остатка.");
}