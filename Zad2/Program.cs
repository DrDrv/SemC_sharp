using System;

namespace Massive
{// Вход два числа - Выход: Большее и Меньшее
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два числа:");
            Console.Write("Первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine(a + " - Меньшее число, " + b + " - Большее число, ");
            }
            else if (a > b)
            {
                Console.WriteLine(b + " - Меньшее число, " + a + " - Большее число, ");
            }
            else Console.WriteLine("Числа равны!");
        }
    }
}