// Поиск кратчайшего пути по точкам
// Сначала для трех точек
Random rnd = new Random();
double[,] arr = new double[4,4];
//double max1 = 0;

// Начальные координаты нахождения
arr[0,0] = 0;
arr[0,1] = 0;
arr[0,2] = 0;
arr[0,3] = 0;
//Генерируем набор кородинат точек 
for (int i = 1; i < 4; i++)
{
    arr[i,0] = rnd.Next(0,20);     //Координаты по X-ам
    arr[i,1] = rnd.Next(0,20);     //Координаты по Y-ам
    arr[i,2] = 0;                  //Индификатор прохождения через точку (Для N точек)
    arr[i,3] = Math.Sqrt (Math.Pow((arr[i,0]-arr[0,0]),2) + Math.Pow((arr[i,1]-arr[0,1]),2));  //Расстояние до точки
    Console.WriteLine(arr[i,0]+":"+arr[i,1]+":"+arr[i,2]+"\t ras="+arr[i,3]);
}
//Отсортируем массив координат по дальности точек t_c - самая дальняя 
//и присвоим точкам их значения растояния от начальной точки
double rast_0a = 0, rast_0b = 0, rast_0c = 0, rast_ab = 0, rast_ac = 0, rast_bc = 0, rast_k = 0 ;
int t_a = 1, t_b = 1, t_c = 1;
for (int i = 1; i < 4; i++)
{
    if (arr[t_c,3] < arr[i,3])
    {
        t_c = i;
        rast_0c = arr[i,3];
    }
    if (arr[t_a,3] > arr[i,3])
    {
        t_a = i;
    }
}
for (int i = 1; i < 4; i++)
{
    if ((arr[t_a,3] < arr[i,3]) & (arr[t_c,3] > arr[i,3]))
    {
        t_b = i;
    }
}
rast_0a = arr[t_a,3];
rast_0b = arr[t_b,3];
//Рачитываем остальные растояния между точками 
Console.WriteLine("a = "+t_a+"   b = "+t_b+"    c = "+t_c);
rast_ab = Math.Sqrt (Math.Pow((arr[t_a,0]-arr[t_b,0]),2) + Math.Pow((arr[t_a,1]-arr[t_b,1]),2));
rast_ac = Math.Sqrt (Math.Pow((arr[t_a,0]-arr[t_c,0]),2) + Math.Pow((arr[t_a,1]-arr[t_c,1]),2));
rast_bc = Math.Sqrt (Math.Pow((arr[t_c,0]-arr[t_b,0]),2) + Math.Pow((arr[t_c,1]-arr[t_b,1]),2));
Console.WriteLine("0A "+rast_0a);
Console.WriteLine("0B "+rast_0b);
Console.WriteLine("AB "+rast_ab);
Console.WriteLine("AC "+rast_ac);
Console.WriteLine("BC "+rast_bc);
//Итого у нас 6 расстояний =) а нужно рассчитывать только 5, что б получить 4 пути - пока тупо их посчитаем
double[] pway = new double[4];
string[] ptrack = new string[4];
string ptrack_k = "";
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
for (int i= 0; i < 4; i++)
{
    if (rast_k > pway[i])
    {
        rast_k = pway[i];
        ptrack_k = ptrack[i];
    }
}
Console.WriteLine(ptrack_k);
Console.WriteLine("Короткий путь = " + rast_k);