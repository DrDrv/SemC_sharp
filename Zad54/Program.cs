// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//  по убыванию элементы каждой строки двумерного массива.
Random rnd = new Random();
int rows = rnd.Next(2,5);
int cols = rnd.Next(2,15);
int[,] array = new int[rows,cols]; 

FillArr();
PrintArr();
SortStrArr();
PrintArr();

void SortStrArr()
{
    int tempval = 0;
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

        }
    }    
}


void FillArr()
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
            {
                array[i,j] = rnd.Next(50);
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
