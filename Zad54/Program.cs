// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//  по убыванию элементы каждой строки двумерного массива.
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
//  будет находить строку с наименьшей суммой элементов.
Random rnd = new Random();
int rows = rnd.Next(2,5);
int cols = rnd.Next(2,15);
int rangmass = 50;
int[,] array = new int[rows,cols]; 

FillArr();
PrintArr();
SortStrArr(); // Сортировка строк по убыванию


void SortStrArr() // Решение задачи 54
{
    int tempval = 0; 
    int[] summstr = {rangmass * cols, 0, 0}; // Назначаем максимальное значение, если все значения, в нашем случае, строки будут равны по 49
    Console.WriteLine("+= Сортировка строк по убыванию =+");
    for (int j=0; j < rows; j++)
    {
        for (int i=0; i < cols; i++)
        {
            for (int k=0; k < cols-1; k++)
            {
                if (array[j,k]<array[j,k+1])
                {
                    tempval = array[j,k];
                    array[j,k] = array[j,k+1];
                    array[j,k+1] = tempval;
                }
            }
            summstr[2] +=array[j,i]; // Решение задачи 56
        }
        if (summstr[0] > summstr[2])
        {
            summstr[1] = j;
            summstr[0] = summstr[2];
        } 
        summstr[2] = 0;
    } 
    PrintArr(); // Вывод результата по задаче 54
    Console.WriteLine();
    Console.WriteLine($"Строка {summstr[1]+1} является с наименьшей суммой элементов равной {summstr[0]}"); 
    // конец решения задачи 56
    Console.WriteLine();
}

void FillArr()
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
            {
                array[i,j] = rnd.Next(rangmass);
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
}