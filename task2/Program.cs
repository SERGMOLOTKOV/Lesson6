using System;

class Program
{
    static void Main()
    {
        string inputString = "HeLLo WorLD";
        string resultString = ConvertToUpperToLower(inputString);
        
        Console.WriteLine("Результирующая строка: " + resultString);
    }

    static string ConvertToUpperToLower(string input)
    {
        // Создаем пустую строку для результата
        string result = "";

        // Обходим каждый символ входной строки
        foreach (char c in input)
        {
            // Проверяем, является ли символ заглавной буквой
            if (char.IsUpper(c))
            {
                // Если да, добавляем его же в нижнем регистре к результату
                result += char.ToLower(c);
            }
            else
            {
                // Если это не заглавная буква, добавляем его без изменений
                result += c;
            }
        }

        return result;
    }
}
