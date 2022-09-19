void FindPointCrossing(double b1,double k1, double b2,double k2)
{
    double pointCrossing1 = 0;
    double pointCrossing2 = 0;
    double x = 0;

    x = (b2 - b1) / (k1 - k2);

    pointCrossing1 = k1 * x + b1;
    pointCrossing2 = k2 * x + b2;

    Console.WriteLine($"Точка пересечения прямых ({b1};{k1}) и ({b2};{k2}) равна ({pointCrossing1};{pointCrossing2})");
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

