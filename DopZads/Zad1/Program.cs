// Поиск кратчайшего пути по точкам
// Сначала для трех точек
Random rnd = new Random();
int kol_n = 4;
double[,] arr = new double[4, kol_n];
// Начальные координаты нахождения
arr[0, 0] = 0;
arr[0, 1] = 0;
arr[0, 2] = 0;
arr[0, 3] = 0;
//Генерируем набор кородинат точек 
for (int i = 1; i < kol_n; i++)
{
    arr[i, 0] = rnd.Next(0, 20);     //Координаты по X-ам
    arr[i, 1] = rnd.Next(0, 20);     //Координаты по Y-ам
    arr[i, 2] = 0;                  //Индификатор прохождения через точку (Для N точек)
    arr[i, 3] = Math.Sqrt(Math.Pow((arr[i, 0] - arr[0, 0]), 2) + Math.Pow((arr[i, 1] - arr[0, 1]), 2));  //Расстояние до точки
    //-*-*-
    Console.WriteLine(arr[i, 0] + ":" + arr[i, 1] + ":" + arr[i, 2] + "\t ras=" + arr[i, 3]);
    //-*-*-
}
//Здесь алгоритм сортировки массива по удаленности от начала координат
for (int k = 1; k < kol_n - 1; k++)
{
    for (int i = 1; i < kol_n - k; i++)
    {
        if (arr[i, 3] > arr[i + 1, 3]) { Per_ka(i); }
    }
}
 //-*-*-
 Console.WriteLine(arr[0, 3] + "\t" + arr[1, 3] + "\t" + arr[2, 3] + "\t" + arr[3, 3]);
 //-*-*-
int t_n = 0;

// Здесь будет цикличность для N точек
double rast_0a = 0, rast_0b = 0, rast_0c = 0, rast_ab = 0, rast_ac = 0, rast_bc = 0, rast_k = 0;
for (int k = 1; k < kol_n - 2; k++)
{
    rast_0a = Rast_t2t(t_n,k);
    rast_0b = Rast_t2t(t_n,k+1);
    rast_0c = Rast_t2t(t_n,k+2);
    rast_ab = Rast_t2t(k,k+1);
    rast_ac = Rast_t2t(k,k+2);
    rast_bc = Rast_t2t(k+1,k+2);
    // -*-*-
    Console.WriteLine("0A " + rast_0a);
    Console.WriteLine("0B " + rast_0b);
    Console.WriteLine("0С " + rast_0c);
    Console.WriteLine("AB " + rast_ab);
    Console.WriteLine("AC " + rast_ac);
    Console.WriteLine("BC " + rast_bc);
    // -*-*-
    double min_rast = P_way(rast_0c+rast_0a, rast_bc+rast_0b, rast_ab);
    if (P_way(rast_0a, rast_ab, rast_bc) < min_rast )
    {

    }

}



//Далее уводим в функцию с возвратом значений

//Отсортируем массив координат по дальности точек t_c - самая дальняя 
//и присвоим точкам их значения растояния от начальной точки

//Рачитываем остальные растояния между точками 


//Итого у нас 6 расстояний =) а нужно рассчитывать только 5, что б получить 4 пути - пока тупо их посчитаем
//double[] pway = new double[4];
//string[] ptrack = new string[4];
/*string ptrack_k = "";
pway[0] = rast_0a + rast_ac + rast_bc;
ptrack[0] = "A - C - B";
pway[1] = rast_0a + rast_ab + rast_bc;
ptrack[1] = "A - B - C";
pway[2] = rast_0b + rast_bc + rast_ac;
ptrack[2] = "B - C - A";
pway[3] = rast_0b + rast_ab + rast_ac;
ptrack[3] = "B - A - C";
rast_k = pway[0];
ptrack_k = ptrack[0];
int inway = 0;
for (int i = 0; i < 4; i++)
{
    if (rast_k > pway[i])
    {
        rast_k = pway[i];
        ptrack_k = ptrack[i];
        inway = i;
    }
}
Console.WriteLine(ptrack_k);
Console.WriteLine("Короткий путь = " + rast_k);
*/
//Выводим на будущее результаты перемещения на точку -1
//if (inway == 0) { arr[t_a, 2] = 1; arr[t_c, 2] = 1; arr[0, 0] = arr[t_c, 0]; arr[0, 1] = arr[t_c, 1]; }
//if (inway == 1) { arr[t_a, 2] = 1; arr[t_b, 2] = 1; arr[0, 0] = arr[t_b, 0]; arr[0, 1] = arr[t_b, 1]; }
//if (inway == 2) { arr[t_b, 2] = 1; arr[t_c, 2] = 1; arr[0, 0] = arr[t_c, 0]; arr[0, 1] = arr[t_c, 1]; }
//if (inway == 3) { arr[t_a, 2] = 1; arr[t_b, 2] = 1; arr[0, 0] = arr[t_a, 0]; arr[0, 1] = arr[t_a, 1]; }
//Console.WriteLine("t_a = " + arr[t_a, 2]);
//Console.WriteLine("t_b = " + arr[t_b, 2]);
//Console.WriteLine("t_c = " + arr[t_c, 2]);

void Per_ka (int i)
{
    for (int j = 0; j < 4; j++)
    {
        double kord_p = arr[i, j];
        arr[i, j] = arr[i + 1, j];
        arr[i + 1, j] = kord_p;
    }    
}
double Rast_t2t(int a, int b)
{
    double rast_e = Math.Sqrt(Math.Pow((arr[a, 0] - arr[b, 0]), 2) + Math.Pow((arr[a, 1] - arr[b, 1]), 2));
    return(rast_e);
}
double P_way (double a, double b,double c)
{
    double pway = rast_0a + rast_ac + rast_bc;
    return(pway);
}