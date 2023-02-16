using System;

class Program
{
    static void Main(string[] args)
    {
        // Оголошуємо лямбда-функції
        Func<double, double, double> Add = (x, y) => x + y;
        Func<double, double, double> Sub = (x, y) => x - y;
        Func<double, double, double> Mul = (x, y) => x * y;
        Func<double, double, double> Div = (x, y) => y != 0 ? x / y : throw new ArgumentException("Ділення на нуль неможливе");

        // Отримуємо вхідні дані від користувача
        Console.Write("Введіть перше число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = double.Parse(Console.ReadLine());

        // Виконуємо арифметичні дії з використанням лямбда-функцій
        Console.WriteLine("Результат додавання: " + Add(num1, num2));
        Console.WriteLine("Результат віднімання: " + Sub(num1, num2));
        Console.WriteLine("Результат множення: " + Mul(num1, num2));

        try
        {
            Console.WriteLine("Результат ділення: " + Div(num1, num2));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
