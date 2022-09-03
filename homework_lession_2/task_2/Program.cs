void ThirthDigit(int number)
{
        if(number > 99)
        {
                int digit = number;
                while(digit > 1000)
                {
                        digit /= 10;
                }
                digit %= 10;
                Console.WriteLine($"Третья цифра числа {number} - {digit}");
        }

        else
        {
            Console.WriteLine($"Число {number} не имеет третьей цифры");
        }
}

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

ThirthDigit(number);

