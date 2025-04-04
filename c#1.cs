using System;

class AgeCalculator
{
    public static void Main()
    {
        Console.WriteLine("Калькулятор возраста");
        Console.Write("Введите год вашего рождения: ");
        
        int birthYear = Convert.ToInt32(Console.ReadLine());
        int currentYear = DateTime.Now.Year;
        
        if (birthYear > currentYear)
        {
            Console.WriteLine("Ошибка: год рождения не может быть больше текущего года!");
            return;
        }
        
        int age = currentYear - birthYear;
        
        Console.WriteLine($"Ваш возраст: {age}");
        Console.WriteLine(age < 18 ? "Вы еще несовершеннолетний" : "Вы совершеннолетний");
    }
}