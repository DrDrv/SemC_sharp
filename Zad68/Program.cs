// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(n,m) = 29
Random rnd = new Random();
int numberM = 3;
int numberN = 2;
Console.WriteLine($"Функция Аккермана A({numberM}, {numberN}) = {Akkerman(numberM,numberN)}");

int Akkerman(int numM, int numN)
{
    if (numM == 0) return (numN + 1);
    if ((numN == 0) & (numM > 0)) return (Akkerman(numM - 1, 1));
        else return (Akkerman(numM - 1, Akkerman(numM, numN - 1)));
}