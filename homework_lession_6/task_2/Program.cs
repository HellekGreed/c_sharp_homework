void FindPointCrossing(double b1,double k1, double b2,double k2)
{
    double y = 0;
    double x = 0;

    x = (b2 - b1) / (k1 - k2);

    y = k1 * x + b1;

    Console.WriteLine($"Координаты точки пересечения прямых ({b1};{k1}) и ({b2};{k2}) равны ({Math.Round(x, 2)};{Math.Round(y, 2)})");
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

FindPointCrossing(b1, k1, b2, k2);

