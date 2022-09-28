int Akkerman(int m, int n)
{
        if(m == 0)
        {
                return n + 1;
        }

        else if(m != 0 && n == 0)
        {
                return Akkerman(m - 1, 1);
        }

        else
        {
                return Akkerman(m - 1, Akkerman(m, n - 1));
        }
}
Console.Write("Введите М: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();

Console.Write("Введите N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();

int result = Akkerman(m, n);

Console.Write($"A({m},{n}) = {result}");

