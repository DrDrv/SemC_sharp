// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Random rnd = new Random();
int rowsa = rnd.Next(2,7), colsa = rnd.Next(2,7);
int rowsb = colsa, colsb = rnd.Next(2,7); //Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В .
int rangmass = 6;
int[,] arraya = new int[rowsa,colsa]; 
int[,] arrayb = new int[rowsb,colsb];
int[,] arrayc = new int[rowsa,colsb]; //В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В
FillArr(arraya, rowsa, colsa);
PrintArr(arraya, rowsa, colsa);
FillArr(arrayb, rowsb, colsb);
PrintArr(arrayb, rowsb, colsb);
MultiMatrix();
PrintArr(arrayc, rowsa, colsb);

void MultiMatrix() // Решение задачи 58
{
    Console.WriteLine("+= Перемножение матриц =+");
    for (int s = 0; s < rowsa; s++)     
    {
        for (int c = 0; c < colsb; c++)
        {
            for (int f = 0; f < rowsb; f++)
            {
                arrayc[s,c] += arraya[s,f] * arrayb[f,c];
            }
            
        }
    } 
}

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