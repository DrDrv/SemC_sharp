//   Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Random rnd = new Random();
int kol = 10, sign_min = 0, sign_max = 10;
int[] arr = new int[kol];
FillArr(); PrintArr();
MatArr();

void MatArr()
{
    Console.WriteLine("+= Решение задачи =+");
    int len = arr.Length;
    int sum_nechetn_index = 0;
    for (int k = 0; k < len; k++)
    {
        if ( k/2*2 != k) 
        {
            sum_nechetn_index += arr[k];
            Console.WriteLine($"Индекс массива {k} - число {arr[k]} ");
        }
    }
    Console.WriteLine($"Сумма элементов в массиве с нечетными индексами {sum_nechetn_index} !");
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