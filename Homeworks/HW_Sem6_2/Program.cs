// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.WriteLine("Вводите слово латинскими буквами обоих регистров: ");
string start = Console.ReadLine();
string result = start.ToLower();
Console.WriteLine(result);
