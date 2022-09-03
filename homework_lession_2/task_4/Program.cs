void Glo()
{
        int x = new Random().Next(1, 2000000000);
        int x2 = x;
        int count = 1;
        if(x2 > 9)
        {
            while (x2 > 100)
            {
                x2 = x2 / 10;
                count = count * 10;
            }
            int result = ((x2 / 10) * count) + (x % count);
            Console.WriteLine($"Число {x} без второй цифры с лева : {result}");
        }
        else
        {
                Console.WriteLine($"В числе {x} нет второй цифры");
        }
}

Glo();

