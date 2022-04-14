using System;
class Programm
{
    static void Main()
    {
        Random rnd = new Random();
        Console.WriteLine($"+= Решение задачи 1 =+");
        //1. Дано число n. Получите число, записанное в обратном порядке.
        //345 >> 543
        //81 >> 18
        int numberA = rnd.Next(10,1000);
        int rezult = 0;
        Console.WriteLine($"Входное число - {numberA}");
        Perevert(numberA);
        Console.WriteLine($"Выходное число - {rezult}");

        int Perevert(int num)
        {
            if (num < 1) return (rezult);
            rezult *= 10;
            rezult += num%10;
            Perevert (num/10);
            return(0);
        }

    }
}