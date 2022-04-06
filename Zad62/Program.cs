// Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.
int rows = 4, cols = rows;
int[,] array = new int[rows, cols]; 
// Начало решения Задачи
int znachelmatrix = 1; // первое значение матрицы
FillArr(array, rows, cols);
PrintArr(array, rows, cols);

void FillArr(int[,] arr, int row, int col)
{
    Console.WriteLine("+= Заполняем массив =+");
    int flag = 0;
    int ik = 0, jk = 0, k = 0 ; // k - это кол-во полных кругов
    while (znachelmatrix <= rows*cols)
    {
        if (flag == 0)
        {
            for ( int j = jk; j < col - k; j++)
            {
                arr[ik,j] = znachelmatrix++;
                jk = j;
            }
            flag = 1;
            ik++;
        }
        if ( flag == 1)
        {
            for (int i = ik; i < row - k; i++)
            {
                arr[i,jk] = znachelmatrix++;
                ik = i;
            }
            flag = 2;
            jk--;         
        }
        if ( flag == 2)
        {
            for (int j = jk; j > k-1; j--)
            {
                arr[ik,j] = znachelmatrix++;
                jk = j;
            }
            flag = 3;
            ik--;
        }
        if ( flag == 3)
        {
            for (int i = ik; i > k; i--)
            {
                arr[i,jk] = znachelmatrix++;
                ik = i;
            }
            flag = 0;
            jk++;
        }
        k++;
    }
}
void PrintArr(int[,] arr, int row, int col)
{
    Console.WriteLine("+= Вывод в консоль массива =+");
    for (int i=0; i < row; i++)
    {
        for (int j=0; j < col; j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}