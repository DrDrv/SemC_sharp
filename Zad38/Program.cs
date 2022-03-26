//   Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Random rnd = new Random();
int kol = 10, sign_min = 0, sign_max = 100;
int[] arr = new int[kol];
FillArr(); PrintArr();
MatArr();

void MatArr()
{
    Console.WriteLine("+= Решение задачи =+");
    int len = arr.Length;
    int min = arr[0], max = arr[0];
    for (int k = 0; k < len; k++)
    {
        if ( arr[k]<min) min = arr[k];
        if ( arr[k]>max) max = arr[k];
    }
    Console.WriteLine($"Максимальное число массива {max}");
    Console.WriteLine($"Минимальное число массива {min}");
    Console.WriteLine($"Разница максимума и минимума = {max-min}");
}

void FillArr()
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < kol; i++)
    {
        arr[i] = rnd.Next(sign_min, sign_max);
    }
}
void PrintArr()
{
    Console.WriteLine("+= Вывод в консоль массива =+");
    for (int i=0; i < kol; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}