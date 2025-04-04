using System;

class TimeOfDay
{
    public static void Main()
    {
        Console.WriteLine("Определение времени суток");
        Console.Write("Введите текущий час (0-23): ");
        
        string input = Console.ReadLine();
        int hour;
        
        bool isNumber = true;
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                isNumber = false;
                break;
            }
        }
        
        if (!isNumber)
        {
            Console.WriteLine("Ошибка: нужно ввести число!");
            return;
        }
        
        hour = Convert.ToInt32(input);
        
        if (hour >= 0 && hour <= 5)
            Console.WriteLine("Ночь");
        else if (hour >= 6 && hour <= 11)
            Console.WriteLine("Утро");
        else if (hour >= 12 && hour <= 17)
            Console.WriteLine("День");
        else if (hour >= 18 && hour <= 23)
            Console.WriteLine("Вечер");
        else
            Console.WriteLine("Ошибка: число должно быть от 0 до 23!");
    }
}