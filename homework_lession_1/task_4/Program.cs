﻿Console.Write("Введите целое, положительное число: ");
int number = int.Parse(Console.ReadLine());

int count = 1;

while (count <= number)
{
        if (count % 2 == 0)
        {
                Console.WriteLine(count);
        }
        count++;
}
