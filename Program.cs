using System;

class Program
{
    static void Main()
    {
        string inputString = "топот";
        bool isPalindrome = IsPalindrome(inputString);
        
        if (isPalindrome)
        {
            Console.WriteLine("Строка \"" + inputString + "\" является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка \"" + inputString + "\" не является палиндромом.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Приводим строку к нижнему регистру для удобства сравнения
        str = str.ToLower();

        // Используем два указателя, один в начале строки, другой в конце
        int left = 0;
        int right = str.Length - 1;

        // Пока указатели не пересеклись
        while (left < right)
        {
            // Если символы на текущих позициях не совпадают, строка не является палиндромом
            if (str[left] != str[right])
            {
                return false;
            }

            // Передвигаем указатели к середине
            left++;
            right--;
        }

        // Если дошли сюда, значит строка является палиндромом
        return true;
    }
}
