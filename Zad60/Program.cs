// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Random rnd = new Random();
int rows = rnd.Next(3,7), cols = rnd.Next(3,7), deps = rnd.Next(3,7);
int rangmassmin = 100, rangmassmax = 1000; // Максимальное и минимальное значение элементов массива
int[,,] array = new int[rows, cols, deps]; 
// Начало решения Задачи
int delta = (rangmassmax - rangmassmin)/rows/cols/deps;  // берем и расчитываем дельту в интервале значений массива, для уникальности значений 
int count = 0; // счетчик дельты
FillArr(array, rows, cols, deps);
PrintArr(array, rows, cols, deps);


void FillArr(int[,,] arr, int row, int col, int dep)
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            {
                for (int f = 0; f < dep; f++)
                {
                    arr[i,j,f] = rnd.Next(rangmassmin + delta*count,rangmassmin + delta * (count+1));
                    count++;
                }
                
            }
    }
}
void PrintArr(int[,,] arr, int row, int col, int dep)
{
    Console.WriteLine("+= Вывод в консоль массива =+");
    for (int i=0; i < row; i++)
    {
        for (int j=0; j < col; j++)
        {
            for (int f = 0; f < dep; f++)
                {
                    Console.WriteLine($" Элемент [ {i}, {j}, {f}] = {arr[i,j,f]} ");
                }
        }
    }
}