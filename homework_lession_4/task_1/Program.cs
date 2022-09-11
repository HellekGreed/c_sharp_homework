double GetExp(double number1, double number2)
{

         //double result = Math.Pow(number1, number2);
        
         //Сам алгоритм возведения в степень я реализовал бы так:
        
        double result = 1;

        
        if(number2 > 0)  // Обычное возведение в степень
        {
                for(int i = 1; i <= number2; i++)
                {
                result *= number1;
                }
                return result;
        }
        if(number2 < 0)  // Возведение в отрицательную степень степень даёт еденицу деленную на результат возведения в степень
        {
                for(int i = 1; i <= Math.Abs(number2); i++)
                {
                result *= number1;
                }
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

