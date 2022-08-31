Console.Write("Введите целое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

if (number_1 > number_2)
{
        Console.WriteLine($"Число {number_1} больше числа {number_2}.");
}

if (number_1 < number_2)
{
        Console.WriteLine($"Число {number_2} больше числа {number_1}.");
}

if (number_1 == number_2)
{
        Console.WriteLine($"Числа {number_1} и {number_2} равны.");
}

