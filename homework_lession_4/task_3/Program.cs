void ShowArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
        {
                Console.Write($"{array[i]}, ");
        }
}


int[] array = new int[8];

Console.WriteLine("Введите целые числа(после введения каждого числа нижмите Enter)");
for(int i = 0; i < array.Length; i++)
{
        array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Введенные вами числа: ");
ShowArray(array);

