/*   Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/
Random rnd = new Random();
int cols = rnd.Next(2,6), rows = rnd.Next(5,10); //параметры двумерного массива
int sign_min = 1, sign_max = 10; // минимальное и максимальное значение для значений массива
double[,] array = new double[rows,cols];

Console.WriteLine($"\t+=== Задача 47 ===+");
FillArr(47, sign_min, sign_max);
PrintArr();

Console.WriteLine($"\t+=== Задача 50 ===+");
Zad50(); // Вывод элементов массива по координатам

Console.WriteLine($"\t+=== Задача 52 ===+");
FillArr(52, sign_min, sign_max);
PrintArr();
Zad52(); // Вывод среднее арифметическое по каждому столбцу

void Zad50()
{
    int userEnter = rnd.Next(1,6); //Сколько раз пользователь ввел координаты
    for (int j =0; j < userEnter; j++ )
    {
        int userRow = rnd.Next(rows); // Пользователь ввел координаты строки
        int userCol = rnd.Next(cols); // Пользователь ввел координаты столбца
        Console.WriteLine($"Введенный вами номер столбца - {userCol+1}");
        Console.WriteLine($"Введенный вами номер строки  - {userRow+1}");
        Console.WriteLine($"Элемент массива с координатами {userRow+1}, {userCol+1}  =  {array[userRow,userCol]}");
    }
    Console.WriteLine();
}

void Zad52()
{
    Console.WriteLine("+= среднее арифметическое по каждому столбцу =+");
    double summ;
    for (int j=0; j < cols; j++)
    {
        summ = 0;
        for (int i=0; i < rows; i++)
        {
            summ += array[i,j];
        }
        Console.WriteLine($"Столбец {j+1}, среднее арифметическое элементов столбца = {summ/rows}");
    }
    Console.WriteLine();
}

void FillArr(int flag, int min, int max)
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
        {
            if (flag == 47) array[i,j] = rnd.NextDouble();
            if (flag == 52) array[i,j] = rnd.Next(min,max);
        }
    }
}
void PrintArr()
{
    Console.WriteLine("+= Вывод в консоль массива =+");
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}