// Задание 1:
// Поиск элемента в массиве
// Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве.
// Программа должна вывести: Присутствует/Не присутствует.

int[] array = new int[5] {25, 64, 11, 98, 154};

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        isExistNum = true;
        break;
    }

}
// тернарный оператор (Если ..., то выводим Да, иначе выаодим Нет)
string result = isExistNum ? "Присутствует" : "Не присутствует";

// Console.WriteLine(result);
Console.WriteLine(isExistNum ? "Присутствует" : "Не присутствует");