void SecondDigit(int number)
{
        int result = (number / 10) % 10; 
        Console.WriteLine($"Второй разряд числа {number} - {result}");
}

Console.Write("Введите целое, трехзначное число: ");
int digit = int.Parse(Console.ReadLine());

SecondDigit(digit);

