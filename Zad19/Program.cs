// Задача 19 - Число 5значное - палиндром ?
Console.WriteLine("-=Палиндром - симметричное число=-");
Random rnd = new Random();
//Console.WriteLine("Метод тестовое число " + 65856 + Smetod(Convert.ToString(65856)) + " является палиндромом");
for (int j=0; j<3; j++)
{
    int num_5 = rnd.Next(10000,100000);
    Console.WriteLine("Математический метод: число " + num_5 + Mmetod(num_5) + "является палиндромом");
    Console.WriteLine("Текстовый метод: число " + num_5 + Smetod(Convert.ToString(num_5)) + "является палиндромом");
}
// Математическое решение палиндрома
string Mmetod(int n)
{
    int i = 0;
    int n_n = n;
    while (n >= 1)
    {
        i *= 10;
        i = i + n%10;
        n = n/10;
    }
    if (n_n==i) {return (" ");}
    else {return (" НЕ ");}
}
// Текстовое решение палиндрома
string Smetod(string n)
{
    string t = "";
    for (int k = (n.Length - 1); k >= 0; k--)
    {
        t = t + n[k];
    }
    if (n==t) {return (" ");}
    else {return (" НЕ ");}
}