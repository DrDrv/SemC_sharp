/*   Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/
Random rnd = new Random();
int cols = rnd.Next(2,6), rows = rnd.Next(5,10);
double[,] array = new double[rows,cols];

Console.WriteLine($"\t+=== Задача 47 ===+");
FillArr();
PrintArr(array);

Console.WriteLine($"\t+=== Задача 50 ===+");
Zad50(); // Вывод элементов массива по координатам

Console.WriteLine($"\t+=== Задача 52 ===+");
//Zad50(); // Вывод элементов массива по координатам

void Zad50()
{
    int userEnter = 3; //Сколько раз пользователь ввел координаты
    for (int j =0; j < userEnter; j++ )
    {
        int userRow = rnd.Next(rows); // Пользователь ввел координаты строки
        int userCol = rnd.Next(cols); // Пользователь ввел координаты столбца
        Console.WriteLine($"Введенный вами номер столбца - {userCol+1}");
        Console.WriteLine($"Введенный вами номер строки  - {userRow+1}");
        Console.WriteLine($"Элемент массива с координатами {userRow+1}, {userCol+1}  =  {array[userRow,userCol]}");
    }
}

void FillArr()
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
        {
            array[i,j] = rnd.NextDouble();
        }
    }
}
void PrintArr(double[,] arr)
{
    Console.WriteLine("+= Вывод в консоль массива =+");
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
        {
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}