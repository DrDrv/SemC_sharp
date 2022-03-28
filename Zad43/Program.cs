//   Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Random rnd = new Random();
int kol = 4, sign_min = 1, sign_max = 10;
double[] arr = new double[kol];  //[4]  {5,2,9,4};
FillArr(); 
PrintArr();
MatArr();

void MatArr()
{
    Console.WriteLine("+= Решение задачи =+");
    Console.WriteLine($"y = {arr[0]} * x + {arr[1]}");
    Console.WriteLine($"y = {arr[2]} * x + {arr[3]}");
    if (arr[2]!= arr[0]) Console.WriteLine($"Координаты пересечения двух прямых ({(arr[3]-arr[1])/(arr[0]-arr[2])} ; {arr[0]*(arr[3]-arr[1])/(arr[0]-arr[2]) +arr[1]})");
    else Console.WriteLine($"Прямые параллельные !");
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