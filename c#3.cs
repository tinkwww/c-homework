using System;

class SimpleCalculator
{
    public static void Main()
    {
        Console.WriteLine("Калькулятор на switch");
        
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите оператор (+, -, *, /): ");
        string op = Console.ReadLine();
        
        switch (op)
        {
            case "+":
                Console.WriteLine($"Результат: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Результат: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Результат: {num1 * num2}");
                break;
            case "/":
                if (num2 != 0)
                    Console.WriteLine($"Результат: {num1 / num2}");
                else
                    Console.WriteLine("Ошибка: деление на ноль!");
                break;
            default:
                Console.WriteLine("Неверный оператор");
                break;
        }
    }
}