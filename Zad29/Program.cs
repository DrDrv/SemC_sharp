// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
Random rnd = new Random();
int kol = 8, sign = 200;
int[] arr = new int[kol];
FillArr(); PrintArr(); SortArr(); PrintArr();


void SortArr()
{
    Console.WriteLine("+= Сортировочка модулей =+");
    int smez = 0;
    for (int i = 0; i < arr.Length; i++) //кол-во прогонов
    {
        for (int k = 0; k < arr.Length - 1 - i; k++) // кол-во сравниваемых элементов
        {
            if (Math.Abs(arr[k]) > Math.Abs(arr[k+1]))
            {
                smez = arr[k];
                arr[k] = arr[k+1];
                arr[k+1] = smez;
            } 
        }
    }
}
void PrintArr()
{
    for (int i=0; i < kol; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
void FillArr()
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < kol; i++)
    {
        arr[i] = rnd.Next(sign)-sign/2;
    }
}