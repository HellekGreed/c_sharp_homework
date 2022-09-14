int[] GetFillArray(int size)
{
        int[] array = new int[size];
        var random = new Random();
        for(int i = 0;i < array.Length;i++)
        {
                array[i] = random.Next(100, 1000);
        }
        return array;
}

int FindEven(int[] array)
{
        int count = 0;
        for(int i = 0;i < array.Length;i++)
        {
                if(array[i] % 2 == 0)
                {
                        count++;
                }
        }
        return count;
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

int evenNumbers = FindEven(array);
Console.Write($"В сгенерированном масиве четных чисел: {evenNumbers}");


