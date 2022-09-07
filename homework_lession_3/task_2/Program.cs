double GetDistanceTwoPoint(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return distanse;
}

Console.WriteLine("Введите координаты первой точки.");
Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки.");
Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = GetDistanceTwoPoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между двумя точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {Math.Round(result, 2)}");
