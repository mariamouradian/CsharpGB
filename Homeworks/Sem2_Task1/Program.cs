// Напишите программу, которая принимает на вход  трёхзначное число
// и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите целое трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 && a <= 999)
{
    int firstDigit = a / 100; //256 / 100 = 2.56 = 2
    int thirdDigit = a % 10; //256 % 10 = 250 + 6 = 6

    int result = firstDigit * 10 + thirdDigit;
    Console.Write(result);
}
else
{
    Console.Write("Число за пределами диапазона!");
}