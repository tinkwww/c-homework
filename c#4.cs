using System;

class SeasonByMonth
{
    public static void Main()
    {
        Console.WriteLine("Определение времени года по месяцу");
        Console.Write("Введите номер месяца (1-12): ");
        
        string input = Console.ReadLine();
        int month;
        
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
            Console.WriteLine("Ошибка: нужно ввести число от 1 до 12!");
            return;
        }

        month = Convert.ToInt32(input);

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Зима");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Весна");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Лето");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Осень");
                break;
            default:
                Console.WriteLine("Ошибка: месяц должен быть от 1 до 12!");
                break;
        }
    }
}