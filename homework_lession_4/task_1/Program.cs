double GetExp(double number1, double number2)
{

         //double result = Math.Pow(number1, number2);
        
         //Сам алгоритм возведения в степень я реализовал бы так:
        
        double result = 1;

        for(int i = 1; i <= Math.Abs(number2); i++) // Возводим число в степень
        {
                result *= number1;
        }

        if(number2 > 0) // Если степень положительная выводим результат
        {
                return result;
        }

        if(number2 < 0) // Число возведенное в отрицательную степень дает еденицу деленную на результат возведения в степень 
        {
                return 1 / result;
        }
        
        return result; // Любое число за исключением нуля возведенное в нулевую степень дает еденицу

}
Console.Write("Введите целое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите степень в которую хотите возвести число(это должно быть целое число): ");
double number2 = Convert.ToDouble(Console.ReadLine());

double result = GetExp(number1, number2);

Console.WriteLine($"Число {number1} в степени {number2} ровняется {result}");

