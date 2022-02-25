using System;

namespace Massive
{// Вход число - Выход: четное!?
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) 
            {
                Console.WriteLine("Число является ЧЕТНЫМ");
            }
            else Console.WriteLine("Число НЕ является ЧЕТНЫМ");
        }
    }
}