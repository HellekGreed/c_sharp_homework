int[] GetFillArray(int size)
{
        int[] array = new int[size];
        var random = new Random();
        for(int i = 0;i < array.Length;i++)
        {
                array[i] = random.Next(1, 11);
        }
        return array;
}

int[] GetSumCouple(int[] array)
{
        if(array.Length % 2 != 0)
        {
                int[] newArray = new int[array.Length / 2 + 1];

                for(int i = 0;i < newArray.Length - 1;i++)
                {
                        newArray[i] = array[i] * array[array.Length - (i + 1)];
                }

                newArray[newArray.Length - 1] = array[array.Length / 2];

                return newArray;
        }

        else
        {
                int[] newArray = new int[array.Length / 2];

                for(int i = 0;i < newArray.Length;i++)
                {
                        newArray[i] = array[i] * array[array.Length - (i + 1)];
                }

                return newArray;
        }
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

int[] newArray = GetSumCouple(array);
Console.WriteLine("Массив с суммами пар чисел: ");
PrintArray(newArray);


