Console.Write("Введите первое целое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int number_3 = int.Parse(Console.ReadLine());

int max = number_1;

if (number_1 == number_2 & number_1 == number_3)
{
        Console.WriteLine("Все три числа равны.");
}

else
{
    if (number_2 >= max)
    {
            max = number_2;
    }
    if (number_3 >= max)
    {
            max = number_3;
    }
    Console.WriteLine($"Большее из 3-ех чисел, число {max}.");
}

