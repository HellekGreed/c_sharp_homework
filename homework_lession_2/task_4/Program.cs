void Glo()
{
        int x = new Random().Next(0, 2000000000);
        Console.WriteLine(x);
        int x2 = x;
        int count = 1;
        while (x2 > 100)
        {
                x2 = x2 / 10;
                count = count * 10;
        }
        int result = ((x2 / 10) * count) + (x % count);
        Console.WriteLine(result);
}

Glo();

