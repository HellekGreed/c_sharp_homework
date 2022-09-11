int SummDigitNumber(int number)
{
        int tempNumber = Math.Abs(number);
        int result = 0;
        while(tempNumber > 0)
        {
                result += tempNumber % 10;
                tempNumber /= 10;
        }
        return result;
}

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int result = SummDigitNumber(number);

Console.WriteLine($"Сумма цифр в числе {number} равняется {result}");
