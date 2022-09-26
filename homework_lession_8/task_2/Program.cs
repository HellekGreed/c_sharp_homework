int[,] GetRandomArray()
{
        var random = new Random();
        int m = random.Next(2, 6);
        int n = m + 1;
        int[,] array = new int[n, m];
        
        for(int i = 0; i < n; i++)
        {
                for(int j = 0; j < m; j++)
                {
                        array[i, j] = random.Next(0, 10);
                }
        }
        return array;
}

void PrintArray(int[,] array)
{
        for(int i = 0; i < array.GetLength(0); i++)
        {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                        Console.Write($"| {array[i, j]} |");
                }
                Console.WriteLine();
        }
}

int GetRowMaxSum(int[,] array)
{
        int row = 0;
        int minSum = 0;
        int rowSum = 0;

        for(int i = 0; i < array.GetLength(0); i++)
        {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                        rowSum += array[i, j];
                }
                
                if(i == 0)
                {
                        minSum = rowSum;
                }
                if(rowSum < minSum)
                {
                        row = i;
                        minSum = rowSum;
                }
                rowSum = 0;
        }
        return row;
}

int[,] array = GetRandomArray();
PrintArray(array);
Console.WriteLine();

int result = GetRowMaxSum(array);
Console.Write($"Номер строки с наименьшей суммой чисел: {result + 1}");

