int[] array = { 1, 3, 2, 4, 2, 3 };
int[] arrayResult = new int[array.Length / 2];

int left = 0;
int right = array.Length - 1;

while (left < right)
{
    arrayResult[left] = array[left] * array[right];
    left++;
    right--;
}
for (int i = 0; i < arrayResult.Length; i++)
{
    Console.Write(arrayResult[i] + " ");
}
