// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Random rnd = new Random();
int rowsa = rnd.Next(2,7), rowsb = rnd.Next(2,7);
int colsa = rnd.Next(2,7), colsb = rnd.Next(2,7);
int rangmass = 10;
int[,] arraya = new int[rowsa,colsa]; 
int[,] arrayb = new int[rowsb,colsb];

FillArr(arraya, rowsa, colsa);
PrintArr(arraya, rowsa, colsa);
FillArr(arrayb, rowsb, colsb);
PrintArr(arrayb, rowsb, colsb);
/*SortStrArr(); // Сортировка строк по убыванию


void SortStrArr() // Решение задачи 54
{
    int tempval = 0; 
    int[] summstr = {rangmass * cols, 0, 0};
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
*/
void FillArr(int[,] arr, int row, int col)
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < row; i++)
    {
        for (int j=0; j < col; j++)
            {
                arr[i,j] = rnd.Next(rangmass);
            }
    }
}
void PrintArr(int[,] arr, int row, int col)
{
    Console.WriteLine("+= Вывод в консоль массива =+");
    for (int i=0; i < row; i++)
    {
        for (int j=0; j < col; j++)
        {
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine(" ");
    }
}