Console.Write("Введите первое целое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int number_3 = int.Parse(Console.ReadLine());

if (number_1 == number_2 & number_1 == number_3)
{
        Console.WriteLine("Все три числа равны.");
}

else
{
    if (number_1 >= number_2)
    {
            number_2 = number_1;
    }
    if (number_2 >= number_3)
    {
            number_3 = number_2;
    }
    Console.WriteLine($"Большее из 3-ех чисел, число {number_3}.");
}
