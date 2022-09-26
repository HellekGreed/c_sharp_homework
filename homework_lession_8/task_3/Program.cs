int[,] GetRandomArray(int n, int m)
{
        var random = new Random();
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

int[,] GetMultArray(int[,] arrayA, int[,] arrayB)
{
        int[,] resultArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

        for(int i = 0; i < arrayA.GetLength(0); i++)
        {
                for(int j = 0; j < arrayB.GetLength(1); j++)
                {
                        for(int k = 0; k < arrayA.GetLength(1); k++)
                        {
                                resultArray[i, j] += arrayA[i, k] * arrayB[k, j];
                        }
                }
        }
        return resultArray;
}

Console.WriteLine("Перемножение матриц возможно только когда кол-во столбцов первой матрици");
Console.WriteLine("равно кол-ву строк второй матрици");
Console.WriteLine();

Console.Write("Введите желаемое колличество строк в первой матрице: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите желаемое колличество столбцов в первой матрице: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[,] arrayA = GetRandomArray(n, m);

Console.Write("Введите желаемое колличество строк второй матрици: ");
int k = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[,] arrayB = GetRandomArray(m, k);
Console.WriteLine();
Console.WriteLine("Первая матрица: ");
PrintArray(arrayA);
Console.WriteLine();

Console.WriteLine("Вторая матрица :");
PrintArray(arrayB);
Console.WriteLine();

Console.WriteLine("Результат: ");
int[,] resultArray = GetMultArray(arrayA, arrayB);
PrintArray(resultArray);

