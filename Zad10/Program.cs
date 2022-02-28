// Вход многозначное число - Выход перевертыш
Console.WriteLine("Разворачиваем числа");
Random rand = new Random();
for (int i = 1; i <= 3; i++)
{
    int number = rand.Next(100, 1000);
    Console.WriteLine("Исходное число - " + number + " ----> " + Metod(number));
}
// Метод универсальный - можно разворачивать любые целые положительные числа =))) 
int Metod(int s)
{
    int i = 0;
    while (s >= 1)
    {
        i *= 10;
        i = i + s%10;
        s = s/10;
    }
    return (i);
}