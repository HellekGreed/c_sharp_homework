int[,] GetRandomArray()
{
        Console.Write("Введите желаемое колличество строк в массиве: ");
        int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Введите желаемое колличество столбцов в массиве: ");
        int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int[,] array = new int[n,m];
        var random = new Random();

        for(int i = 0; i < n; i++)
        {
                for(int j = 0; j < m; j++)
                {
                        array[i,j] = random.Next(1, 10);
                }
        }
        return array;
}

// Создаю метод именно упорядочивания элементов массива, а не создания нового массива 
// так как именно в этом состоит задача.

int[,] GetSortArray(int[,] array)
{
        int temp = 0;
        for(int i = 0 ; i < array.GetLength(0) ; i++)
        {
                for(int j = 0 ; j < array.GetLength(1) ; j++)
                {
                        for(int k = 0 ; k < array.GetLength(1) ; k++)
                        {
                                for(int n = k; n < array.GetLength(1); n++)
                                {
                                        if(array[i,k] < array[i,n])
                                        {
                                                temp = array[i,k];
                                                array[i,k] = array[i,n];
                                                array[i,n] = temp;
                                        }
                                }
                        }
                }
        }
        return array;
}

void PrintArray(int[,] array)
{
        for(int i = 0;i < array.GetLength(0);i++)
        {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                        Console.Write($"| {array[i,j]} |");
                }
                Console.WriteLine();
        }
}

int[,] array = GetRandomArray();
Console.WriteLine();
PrintArray(array);

Console.WriteLine();

GetSortArray(array);
PrintArray(array);

