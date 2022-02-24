using System;

namespace Massive
{// Вход три числа - Выход: Максимальное
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите три числа:");
            Console.Write("Первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Третье число: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double max = a;
            if (max < b) max = b;
            if (max < d) max = d;
            Console.WriteLine("Максимальное число из введенных: " + max);
        }
    }
}