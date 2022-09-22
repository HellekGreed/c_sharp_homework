int[,] GetRandomArray(int n, int m)
{
        int[,] array = new int[n, m];

        var random = new Random();

        for (int i = 0; i < n; i++)
        {
                for (int j = 0; j < m; j++)
                {
                        array[i, j] = random.Next(1, 10);
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

Console.WriteLine("Задайте размерность массива со случайными числами(это должны быть целые числа).");
Console.Write("Введите колличество строк: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите колличество столбцов: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[,] array = GetRandomArray(n, m);

Console.WriteLine();

Console.WriteLine("Введите позицию в массиве, число в которой вы хотите узнать(это должны быть целые числа).");
Console.Write("Введите номер строки: ");
int stri = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите номер столбца: ");
int colu = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine();

PrintArray(array);

Console.WriteLine();
/*
Я думал как сделать нумерацию позиции, с 0 строки и столбца или с 1. Оставил с 1 так как глупо звучит что 
при задании масива выбрали 4 строки и 4 столбца, а позиции 4,4 нет 
*/
if ( stri > n || colu > m )
{
        Console.WriteLine("Такой позиции в массиве нет.");
}
else
{
        Console.WriteLine($"Число в строке {stri} и столбце {colu} это {array[stri - 1, colu - 1]}.");
}

