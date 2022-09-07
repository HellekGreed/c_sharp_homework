int Reverse(int num)
{        
    int num1 = Math.Abs(num);
    string num2 = null;
    
    while(num1 > 0)
    {
        string n = Convert.ToString(num1 % 10);     
        num2 += n;
        num1 /= 10;
       
    }
    
    return Convert.ToInt32(num2);
}

Console.Write("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Reverse(number1);

if (Math.Abs(number1) == number2)
{
    Console.WriteLine($"Число {number1} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {number1} не является палиндромом.");
}

