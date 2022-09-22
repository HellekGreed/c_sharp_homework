double[,] GetRandomArray()
{
        Console.Write("Введите желаемое коллчичество чисел в строке(это должно быть целое число): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите желаемое коллчичество строк(это должно быть целое число): ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[n, m];
        var random = new Random();

        for( int i = 0; i < n; i++ )
        {
                for( int j = 0; j < m; j++ )
                {
                        int number = random.Next(0, 2);
                        if ( number == 0 )
                        {
                                array[i, j] = Math.Round((random.NextDouble() * random.Next(-10, 10)), 2);
                        }
                        else
                        {
                                array[i, j] = random.Next(-10, 10);
                        }
                }
        }
        return array;
}

void PrintArray(double[,] array)
{
        for( int i = 0; i < array.GetLength(0); i++ )
        {
                for( int j = 0; j < array.GetLength(1); j++ )
                {
                       Console.Write($"| {array[i, j]} |"); 
                }
                Console.WriteLine();
        }
}

double[,] array = GetRandomArray();

PrintArray(array);

