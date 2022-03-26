//   Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Random rnd = new Random();
int kol = 10, sign_min = 100, sign_max = 1000;
int[] arr = new int[kol];
FillArr(); PrintArr();
MatArr();

void MatArr()
{
    Console.WriteLine("+= Решение задачи =+");
    int len = arr.Length;
    int chetn_num = 0;
    for (int k = 0; k < len; k++)
    {
        if ( arr[k]/2*2 == arr[k]) 
        {
            ++chetn_num;
            Console.WriteLine($"Число {arr[k]} является четным!");
        }
    }
    Console.WriteLine($"Число четных элементов в массиве {chetn_num} !");
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