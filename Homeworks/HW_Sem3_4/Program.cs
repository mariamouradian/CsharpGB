int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int numCopy = num;
int count = 0;
while (numCopy != 0)
{
    numCopy /= 10;
    count++;
}

int[] arr = new int[count];
int index = 0;
while (num != 0)
{
    arr[index] = num % 10;
    num /= 10; // num = mum / 10
    index++;
}
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.Write("]");