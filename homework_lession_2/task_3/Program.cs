void Weekend(int day)
{
        if(day == 6 | day == 7)
        {
                Console.WriteLine($"День недели под номером {day} является выходным.");
        }
        else
        {
                Console.WriteLine($"День недели под номером {day} не является выходным.");
        }
}
Console.Write("Введите целое число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

Weekend(number);

