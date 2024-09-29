// Напишите программу, которая принимает на вход трёхзначное число
// и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите целое трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 && a <= 999)
{
    int secondDigit = a / 10 % 10; //256 / 100 = 2.56 = 2
    int thirdDigit = a % 10; //256 % 10 = 250 + 6 = 6

    int result = secondDigit;
    int count = 1;

    while (count < thirdDigit)
    {
        result = result * secondDigit; // result *= secondDigit
        count++;
    }
    Console.Write(result);
}
else
{
    Console.Write("Число за пределами диапазона!");
}