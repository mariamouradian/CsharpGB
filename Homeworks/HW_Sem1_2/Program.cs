Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a >= b && a <= c ) || (a >= c && a <=b ))
{
    Console.WriteLine(a);
}
else if ((b >= a && b <= c) || (b >= c && b <= a))
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(c);
}