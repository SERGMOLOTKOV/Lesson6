using System;

class Program
{
    static void Main()
    {
        string inputString = "Пример задачи на C#";
        string reversedString = ReverseWords(inputString);
        
        Console.WriteLine("Строка с обратным порядком слов: " + reversedString);
    }

    static string ReverseWords(string input)
    {
        // Разбиваем строку на массив слов, разделенных пробелами
        string[] words = input.Split(' ');

        // Создаем пустую строку для результата
        string result = "";

        // Обходим массив слов в обратном порядке и добавляем каждое слово к результату
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i];

            // Добавляем пробел после каждого слова, кроме последнего
            if (i > 0)
            {
                result += " ";
            }
        }

        return result;
    }
}
