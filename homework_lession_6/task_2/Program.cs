double FindPointCrossing(double b,double k)
{
    double pointCrossing = 0;
    double x = -0.5;
    pointCrossing = k * x + b;
    return pointCrossing;
}

Console.WriteLine("Задайте первую прямую.");
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте вторую прямую.");
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double y1 = FindPointCrossing(b1, k1);
double y2 = FindPointCrossing(b2, k2);

Console.WriteLine($"Точка пересечения прямых ({b1};{k1}) и ({b2};{k2}) равна ({y1};{y2})");

