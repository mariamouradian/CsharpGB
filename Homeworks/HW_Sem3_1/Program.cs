// See//int[] array = new int[5];
//int[] array1 = new int[5] { 3, 6, 8, 2, 9 };
//int[] array2 = new int[] { 3, 6, 8, 2, 9 };
using System.ComponentModel.DataAnnotations;

int[] array = { 1, 3, 4, 19, 3 };
int num = 2;

bool iisExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        iisExistNum = true;
        break;
    }

}
// тернарный оператор (Если ..., то выводим Да, иначе выаодим Нет)
string result = iisExistNum ? "Да" : "Нет";

// Console.WriteLine(result);
Console.WriteLine(iisExistNum ? "Да" : "Нет");