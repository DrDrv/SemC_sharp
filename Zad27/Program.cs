// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Random rnd = new Random();
int chisA = rnd.Next(10,100000);
Console.WriteLine("Число A = " + chisA + "\t Сумма цифр в числе A = " + Sumch(chisA));

int Sumch (int a)
{
    int len = Convert.ToInt32(Convert.ToString(a).Length), res = 0;
    for (int i = 0; i < len; i++)
    {
        res = res + a%10;
        a = a/10;
    }
    return (res);
}