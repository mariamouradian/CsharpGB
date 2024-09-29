Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0)
{
    Console.WriteLine("Число положительное.");
}
else if (a < 0)
{
    Console.WriteLine("Число отрицательное.");
}
else
{
    Console.WriteLine("Число ноль.");
}