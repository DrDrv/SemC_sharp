/*   Дан массив массивов, состоящих из натуральных чисел, размер которого 5. Для каждого элемента-массива найти сумму его элементов и вывести массив с наибольшей суммой. 
 Если таких массивов несколько, вывести массив с наименьшим индексом. */

Random rnd = new Random();
int kol = 5, sign_min = 1, sign_max = 100;
int[,][] arr = new int[kol,3][];
int ch_el_parr = 20;
Console.WriteLine("+= Заполняем массив =+");
for (int j = 0; j<kol; j++)
{
    arr[j,0] = new int[rnd.Next(1,ch_el_parr)];
    arr[j,1] = new int[1];
    arr[j,2] = new int[1];
    FillArr(j,0);
    PrintArr(j,0);
}
Console.WriteLine(" ");
Console.WriteLine("+= Решение задачи =+");
int max_summ_ind = 0;
int max = arr[0,2][0];
for (int s = 0; s<kol; s++)
{
    if (arr[s,2][0] > max)
    {
        max = arr[s,2][0];
        max_summ_ind = s;
    }
    if (arr[s,2][0] == max) 
        {
            if (arr[s,1][0] < arr[max_summ_ind,1][0])
            {
                max_summ_ind = s;
            }
        }
    Console.WriteLine($"Сумма массива {s+1} = {arr[s,2][0]}");
}
Console.WriteLine("");
Console.WriteLine($"+= Массив {max_summ_ind+1} с наибольшей суммой элементов =+");
PrintArr(max_summ_ind,0);
void FillArr(int marr, int str)
{
    arr[marr,1][0] = arr[marr,str].GetLength(0);
    arr[marr,2][0] = 0;
    for (int i=0; i < arr[marr,1][0]; i++)
    {
        arr[marr,str][i] = rnd.Next(sign_min, sign_max);
        arr[marr,2][0] += arr[marr,str][i];
    }
}
void PrintArr(int marr, int str)
{
    int len_arr = arr[marr,str].GetLength(0);
    for (int i=0; i < len_arr; i++)
    {
        Console.Write(arr[marr,str][i] + "\t");
    }
    Console.WriteLine(" ");
}