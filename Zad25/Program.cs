// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
Random rnd = new Random();
int chisA = rnd.Next(10), chisB = rnd.Next(10);
Console.WriteLine("Число A = " + chisA + "\t Число B = " + chisB + "\t Число A в степени B = " + Sqr(chisA, chisB));

int Sqr (int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res *= a;
    }
    return (res);
}