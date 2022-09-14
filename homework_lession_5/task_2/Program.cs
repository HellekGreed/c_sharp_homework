int[] GetFillArray(int size)
{
        int[] array = new int[size];
        var random = new Random();
        for(int i = 0;i < array.Length;i++)
        {
                array[i] = random.Next(-100, 101);
        }
        return array;
}

int GetSumOddPositionNumbers(int[] array)
{
        int sum = 0;
        for(int i = 0;i < array.Length;i++)
        {
                if(i % 2 != 0)
                {
                        sum += array[i];
                }
        }
        return sum;
}

void PrintArray(int[] array)
{
        for(int i = 0;i < array.Length;i++)
        {
                Console.Write($"{array[i]} ");
        }
}

Console.Write("Введите размер массива(Это должно быть целое число): ");
int size = Math.Abs(int.Parse(Console.ReadLine()));
int[] array = GetFillArray(size);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);

Console.WriteLine();

int sum = GetSumOddPositionNumbers(array);

Console.WriteLine($"Сумма цифр находящихся на нечетных позициях равна: {sum}");

