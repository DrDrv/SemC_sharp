// Поиск кратчайшего пути по точкам
// Сначала для трех точек
Random rnd = new Random();
double[,] arr = new double[4,4];

// Начальные координаты нахождения
arr[0,0] = 0;
arr[0,1] = 0;
//Генерируем набор кородинат точек 
for (int i = 1; i < 4; i++)
{
    arr[i,0] = rnd.Next(0,20);     //Координаты по X-ам
    arr[i,1] = rnd.Next(0,20);     //Координаты по Y-ам
    arr[i,2] = 0;                  //Индификатор прохождения через точку (Для N точек)
    arr[i,3] = Math.Sqrt (Math.Pow((arr[i,0]-arr[0,0]),2) + Math.Pow((arr[i,1]-arr[0,1]),2));  //Расстояние до точки
    Console.WriteLine(arr[i,0]+":"+arr[i,1]+":"+arr[i,2]+"      ras="+arr[i,3]);
}
double max = 0, rast_ab, rast_ac, rast_bc ;
int t_a = 1, t_b = 2, t_c = 3;
for (int i = 1; i < 4; i++)
{
    if (max < arr[i,3]) 
    {
        max=arr[i,3];
        t_c = i;
    }
}
Console.WriteLine("a = "+t_a+"   b = "+t_b+"    c = "+t_c);
rast_ab = Math.Sqrt (Math.Pow((arr[t_a,0]-arr[t_b,0]),2) + Math.Pow((arr[t_a,1]-arr[t_b,1]),2));
rast_ac = Math.Sqrt (Math.Pow((arr[t_a,0]-arr[t_c,0]),2) + Math.Pow((arr[t_a,1]-arr[t_c,1]),2));
rast_bc = Math.Sqrt (Math.Pow((arr[t_c,0]-arr[t_b,0]),2) + Math.Pow((arr[t_c,1]-arr[t_b,1]),2));
Console.WriteLine("AB "+rast_ab);
Console.WriteLine("AC "+rast_ac);
Console.WriteLine("BC "+rast_bc);
