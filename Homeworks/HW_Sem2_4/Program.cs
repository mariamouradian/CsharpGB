// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 10)
{
    Console.Write(a);
}
else
{
    while (a > 0)
    {
        int currentDigit = a % 10;
        a /= 10;
        if (a > 0)
        { 
            Console.Write(currentDigit + ","); 
        }
        else 
        { 
            Console.Write(currentDigit); 
        }
    }
}