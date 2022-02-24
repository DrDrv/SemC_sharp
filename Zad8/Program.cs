using System;

namespace Massive
{// Вход число - Выход: четные целые числа от 1 до числа!?
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 1 ) 
            {
                Console.Write("Числовая последовательность четных чисел: ");
                for (int i = 2; i<=a; i+=2) Console.Write(i + ", ");
            }
            else Console.WriteLine("Числовую последовательность построить НЕ удалось!");
        }
    }
}