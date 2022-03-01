// Вход многозначное число - Выход перевертыш
Console.WriteLine("Разворачиваем числа и находим третье число числовой последовательности");
Random rand = new Random();
for (int i = 1; i <= 6; i++)
{
    int number = rand.Next(1, 1000000);
    Console.WriteLine("Исходное число - " + number + " --Математически--> " + Mmetod(number));
    Console.WriteLine("Исходное число - " + number + " --   Текстом   --> " + Smetod(Convert.ToString(number),0));
    Console.WriteLine("Третье число числовой последовательности : " + Smetod(Convert.ToString(number),1));
    Console.WriteLine("----------------------------");
}
// Метод математический универсальный - можно разворачивать любые целые положительные числа =)))
// если число имеет нули в конце числа, то разрядность числа математически уменьшается, т.к. в начале числа\
// 0 не указывается 
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
// Текстовый метод переворота универсальный - можно разворачивать любое количество символов из которых состоит
// число
string Smetod(string s, int d)
{
    char[] arr = s.ToCharArray();
    string t = "";
    for (int k=(s.Length-1); k>=0; k--)
    {
        t = t+arr[k];
    }
    if (d==0) 
    {return (t);}
    else if (d==1) // Выводим третье число из числовой последовательности
    {   
        if (s.Length<3){ return("Третьей цифры нет");} 
        else {return (Convert.ToString(arr[2]));}
    }
    else return("Error");
}


