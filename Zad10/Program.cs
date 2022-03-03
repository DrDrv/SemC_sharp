// Вход многозначное число - Выход перевертыш
Console.WriteLine("Разворачиваем числа");
Random rand = new Random();
for (int i = 1; i <= 3; i++)
{
    int number = rand.Next(100, 1000);
    Console.WriteLine("Исходное число - " + number + " --Математически--> " + Mmetod(number));
    Console.WriteLine(Smetod);
}
// Метод универсальный - можно разворачивать любые целые положительные числа =)))
//если число будет заканчиваться на "0"-и - нули впереди числа не пишутся в числе, если 
//только в строку переводить 
int Mmetod(int n)
{
    int i = 0;
    while (n >= 1)
    {
        i *= 10;
        i = i + n%10;
        n = n/10;
    }
    return (i);
}
string Smetod(string s)
{
    string[] strarr = s.ToStringArray();
    Console.WriteLine(strarr);
}