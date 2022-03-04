// Задача 23 - число (N). таблица кубов чисел от 1 до N
Console.WriteLine("-=таблица кубов чисел от 1 до N=-");
Console.WriteLine(" ");
Random rnd = new Random();
for (int ja = 0; ja < 3; ja++)
{
    int jl = rnd.Next(1, 20);
    Console.Write("Входное число: " + jl + "     кубы до числа: ");
    for (int jk = 1; jk <= jl; jk++)
    {
        Console.Write(Math.Pow(jk, 3) + ",  ");
    }
    Console.WriteLine(" ");
    Console.WriteLine("+===============================================================================+ ");
}