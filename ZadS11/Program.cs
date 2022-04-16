//Задача 1. На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].
Random rnd = new Random();
int n = 0;
int m = 10;
int numberN = 5;
int lenarr = 10;
int year = 2022;
Console.WriteLine($"Входные данные: n = {n}, m = {m}, длина массива = {lenarr}, чистло сравнения - {numberN},  год - {year}");
int[] arr = new int[lenarr];
FillArr(n, m, lenarr);
PrintArr(lenarr);
Matsumm(numberN, lenarr);
VisokosnyGod(year-5);


void PrintArr(int len)
{
    for (int i=0; i < len; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
void FillArr(int min, int max, int len)
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < len; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
}

// Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10. Найдите количество элементов, значение которых больше 5, и их сумму.

void Matsumm(int num,int len)
{
    Console.Write($"Элементы массива больше 5 - ");
    int summ = 0;
    for (int i=0; i < len; i++)
    {
        if (arr[i] > num)
        {
            Console.Write($" {arr[i]}   ");
            summ += arr[i];
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Сумма элементов массива больше 5 = {summ}");
}

//Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.

void VisokosnyGod(int y, int i = 1)
{
    string visokos = "не високосный";
    if (i == 10) return;
    if (y%4 == 0) 
    {
        if (y%100 == 0)
        {
            if (y%400 == 0) visokos = "високосный";
                 else visokos = "не високосный";
        }
        else visokos = "високосный";
    }
    else visokos = "не високосный";
    Console.WriteLine($"Год {y} - {visokos}");
    i++;
    VisokosnyGod(y+1, i);

}