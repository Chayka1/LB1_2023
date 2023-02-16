using System;

class Program
{
    static void Main(string[] args)
    {
        // Оголошуємо анонімний метод, який приймає три цілі числа як параметри і повертає їх середнє арифметичне
        Func<int, int, int, double> average = delegate (int a, int b, int c) {
            return (double)(a + b + c) / 3;
        };

        // Викликаємо анонімний метод з трьома цілими числами як аргументами
        double result = average(1, 2, 3);
        Console.WriteLine("Середнє арифметичне значення: " + result);
    }
}
