using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Создаем строку из символов массива
        string result = ConvertCharArrayToString(charArray);

        // Выводим результат
        Console.WriteLine("Результирующая строка: " + result);
    }

    static string ConvertCharArrayToString(char[,] array)
    {
        // Получаем размеры массива
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Создаем пустую строку
        string result = "";

        // Обходим массив и добавляем символы к строке
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result += array[i, j];
            }
        }

        return result;
    }
}

