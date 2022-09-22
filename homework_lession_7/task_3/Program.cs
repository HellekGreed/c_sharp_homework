int[,] GetRandomArray()
{
        Console.WriteLine("Задайте параметры массива заполненого случайными числами(это должны быть целые числа).");
                
        Console.Write("Введите колличество строк: ");
        int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Введите колличество столбцов: ");
        int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int[,] array = new int[n, m];

        var random = new Random();

        for(int i = 0 ; i < n ; i++)
        {
                for(int j = 0 ; j < m ; j++)
                {
                        array[i, j] = random.Next(1, 10);
                }
        }
        return array;
}

void PrintArray(int[,] array)
{
        for(int i = 0 ; i < array.GetLength(0) ; i++)
        {
                for(int j = 0 ; j < array.GetLength(1) ; j++)
                {
                        Console.Write($"| {array[i, j]} |");
                }
                Console.WriteLine();
        }
}

void GetAverageColumn(int[,] array)
{
        Console.Write("Среднее арифметическое каждого столбца: ");
        double averageColumn = 0;
        for(int i = 0; i < array.GetLength(1); i++)
        {
                averageColumn = 0;

                for(int j = 0; j < array.GetLength(0); j++)
                {
                        averageColumn += Convert.ToDouble(array[j, i]);
                }

                Console.Write($"| {Math.Round(averageColumn / array.GetLength(0), 1)} |");
        }
}

int[,] array = GetRandomArray();

Console.WriteLine();

PrintArray(array);

Console.WriteLine();

GetAverageColumn(array);

