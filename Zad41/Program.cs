//   Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Random rnd = new Random();
//Данные которые ввел пользователь
int kol = rnd.Next(1, 20);  // Какое-то число М = Console.ReadLine();
Console.WriteLine($"Количество чисел: {kol}");
double[] arr = new double[kol]; //Оставлю double - а вдруг пользователь захочет миллионами крутить
int sign_min = 0, sign_max = 100;
FillArr();
// Конец ввода
PrintArr();
MatArr();

void MatArr()
{
    Console.WriteLine("+= Решение задачи =+");
    int count = 0;
    for (int k = 0; k < kol; k++)
    {
        if (arr[k] > 0) count++;
    }
    Console.WriteLine($"Количество введенных чисел больше нуля: {count}");
}

void FillArr()
{
    Console.WriteLine("+= Заполняем массив =+");
    int half = sign_max/2;
    for (int i=0; i < kol; i++)
    {
        // Эмуляция пользователя arr[i] = Console.ReadLine();
        arr[i] = rnd.Next(sign_min, sign_max) - half;
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