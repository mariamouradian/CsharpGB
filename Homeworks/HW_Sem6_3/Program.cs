// Задача 3: 
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

bool IsPolindrome(string str)
{
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}


// string input = "шалаш";
Console.WriteLine("Вводите слово: ");
string input = Console.ReadLine();
bool isPolindrome = IsPolindrome(input);
Console.WriteLine(isPolindrome?"Yes":"No");