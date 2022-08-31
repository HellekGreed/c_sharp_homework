Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
        Console.WriteLine($"Число {number} является четным.");
}
else
{
        Console.WriteLine($"Число {number} не является четным.");
}
