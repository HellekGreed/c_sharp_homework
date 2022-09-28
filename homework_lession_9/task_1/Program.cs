string PrintNumbers(int m, int n)
{
        if(n == m)
        {
                return Convert.ToString(n);
        }
        else if(m < n)
        {
                return m + " " + PrintNumbers(m + 1, n);
        }
        else
        {
                return m + " " + PrintNumbers(m - 1, n);
        }
}
Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write($"Натуральные числа от {m} до {n}: ");
Console.WriteLine(PrintNumbers(m, n));

