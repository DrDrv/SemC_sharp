// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём 
//в промежутке от M до N.
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
Random rnd = new Random();
int numberM = rnd.Next(1,10);
int numberN = rnd.Next(10,50);
int summelements = 0;
// Решение задачи 64
Console.WriteLine($"Нахождение чисел кратных 3 от {numberM} до {numberN}:");
NatNumDevThree(numberM);
Console.WriteLine("");
// Коенц задачи 64
Console.WriteLine("");
// Решение задачи 66
Console.WriteLine($"Cумма натуральных элементов в промежутке {numberM} до {numberN}: {summelements}");
// Конец задачи 66
void NatNumDevThree(int numM)
{
    summelements += numM;
    if (numM%3 == 0) Console.Write($"{numM} \t");
    if (numM == numberN) return;
    NatNumDevThree(numM+1); 
    return;
}