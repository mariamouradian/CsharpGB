Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i = i + 2)
{
  Console.Write(i + " ");
}
Console.WriteLine();