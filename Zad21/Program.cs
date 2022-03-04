// Задача 21 - Расстояние между точками в пространстве
Console.WriteLine("-=Две точки в пространстве=-");
Console.WriteLine(" ");
Random rnd = new Random();
for (int j=0; j<3; j++)
{
    int[] arr = new int[6];
    for ( int jk=0; jk<6; jk++)
    {
        arr[jk] = rnd.Next(100); //x = [0],[3]   y=[1],[4]  z=[2],[5] 
    }
    Console.WriteLine("Координаты точки A  (" + arr[0] + ":" + arr[1] + ":" + arr[2] + ")");
    Console.WriteLine("Координаты точки B  (" + arr[3] + ":" + arr[4] + ":" + arr[5] + ")");
    double ras_e = Math.Sqrt((arr[0]-arr[3])*(arr[0]-arr[3])+(arr[1]-arr[4])*(arr[1]-arr[4])+(arr[2]-arr[5])*(arr[2]-arr[5]));
    Console.WriteLine("Расстояние между точками в пространстве " + ras_e);
    Console.WriteLine("+===========================================================+");
}