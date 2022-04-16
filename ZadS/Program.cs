using System;
class Programm
{
    static void Main(string[] args)
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

        Console.WriteLine($"+= Решение задачи 2 =+");
        //2. Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... 
        //Дано число m. Выведите первые m членов этой последовательности.
        //m = 5 >> 1, 2, 2, 3, 3
        numberA = rnd.Next(5,15);
        Console.WriteLine($"Входное число - {numberA}");
        PrintList(numberA);
        Console.WriteLine();
        
        void PrintList(int num, int nownumber = 1, int kolvo = 1)
        {
            if (num == 0) return;
            Console.Write($"{nownumber} \t");
            if (nownumber == kolvo)
            {
                kolvo = 0;
                nownumber++;
            } 
            kolvo++;
            PrintList(num-1,nownumber,kolvo);
            return;
        }

    }
}