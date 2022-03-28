// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Random rnd = new Random();
int chisA = rnd.Next(10,100000);
Console.WriteLine("Число A = " + chisA + "\t Сумма цифр в числе A = " + Sumch(chisA));

int Sumch (int a)
{
    int res = 0;
    while (a > 1)
    {
        res = res + a%10;
        a = a/10;
    }
    return (res);
}