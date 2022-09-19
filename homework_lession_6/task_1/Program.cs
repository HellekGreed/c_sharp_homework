int[] GetArray()
{  
    Console.Write("Введите колличество чисел которые содираетесь ввести(Это должно быть целое число): ");
    int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    int[] array = new int[size];

    Console.WriteLine("Введите целые числа(после введение числа нажмите Enter): ");

    for( int i = 0;i < size; i++ )
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;

}

int CountPositive(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) { count++; }
    }
    return count;
}

int[] array = GetArray();

int count = CountPositive(array);

Console.WriteLine($"Вы ввели {count} положительных чисел.");

