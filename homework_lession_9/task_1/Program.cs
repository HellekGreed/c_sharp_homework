string PrintNumbers(int m, int n)
{
        string res = String.Empty;

        if(n == m)
        {
                return Convert.ToString(n);
        }
        else if(m < n)
        {
                res += m + " " + PrintNumbers(m + 1, n);
                return res;
        }
        else
        {
                res += m + " " + PrintNumbers(m - 1, n);
                return res;
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

