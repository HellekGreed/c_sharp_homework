double[] GetFillArray(int size)
{
        double[] array = new double[size];
        var random = new Random();
        for(int i = 0;i < array.Length;i++)
        {
                array[i] = random.Next(-100, 101);
        }
        return array;
}

double GetMinMaxDiff(double[] array)
{
        double min = array[0];
        double max = array[0];
        double minMaxDiff = 0;
        for(int i = 0;i < array.Length;i++)
        {
                if(array[i] > max)
                {
                        max = array[i];
                }
                if(array[i] < min)
                {
                        min = array[i];
                }
        }
        minMaxDiff = max - min;
        return minMaxDiff;
}

void PrintArray(double[] array)
{
        for(int i = 0;i < array.Length;i++)
        {
                Console.Write($"{array[i]} ");
        }
}

Console.Write("Введите размер массива(Это должно быть целое число): ");
int size = Math.Abs(int.Parse(Console.ReadLine()));
double[] array = GetFillArray(size);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);

Console.WriteLine();

double minMaxDiff = GetMinMaxDiff(array);

Console.Write($"Разница между минимальным и максимальным числом в массиве равна: {minMaxDiff}");

