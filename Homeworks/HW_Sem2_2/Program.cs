// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0) 
    {
    if (x > 0 && y > 0)
    {
        Console.Write("1");
    }
    if (x > 0 && y < 0)
    {
        Console.Write("2");
    }
    if (x < 0 && y < 0)
    {
        Console.Write("3");
    }
    if (x < 0 && y > 0)
    {
        Console.Write("4");
    }
}
else
{
    Console.Write("x или y равен нулю.");
}