int GetSum(int m, int n)
{
        if(m == n)
        {
                return n;
        }

        else if(m < n)
        {
                return m + GetSum(m + 1, n);
        }

        else
        {
                return m + GetSum(m - 1, n);
        }
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int res = GetSum(m, n);

Console.Write($"Сумма ввсе натуральных чисел от {m} до {n}: {res}");

