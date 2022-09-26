int[,] GetSpiralArray(int n, int m)
{
        int[,] array = new int[n, m];
        int counter = 1;
        int rowsPassed = 0;
        int colPassed = 0;
        int curRow = 0;
        int curCol = 0;
        
        for(int k = 0; k < n * m; k++)
        {
                if (counter == n * m + 1)
                {
                        break;
                }

                int direction = k % 4;

                if(direction == 0)
                {
                        for(int j = colPassed; j < m - colPassed; j++)
                        {
                                array[curRow, j] = counter;
                                counter++;
                                curCol = j;
                        }
                        rowsPassed++;
                }

                else if(direction == 1)
                {
                         for(int i = rowsPassed; i < n - rowsPassed + 1; i++)
                        {
                                array[i, curCol] = counter;
                                counter++;
                                curRow = i;
                        }
                        colPassed++;
                }

                else if(direction == 2)
                {
                        for(int j = curCol - 1; j > colPassed - 2; j-- )
                        {
                                array[curRow, j] = counter;
                                counter++;
                                curCol = j;
                        }
                }

                else if ( direction == 3 )
                {
                        for(int i = curRow - 1; i > rowsPassed - 1; i--)
                        {
                                array[i, curCol] = counter;
                                counter++;
                                curRow = i;
                        }
                }
        }        
        return array;
}

void PrintArray(int[,] array)
{
        for(int i = 0; i < array.GetLength(0); i++)
        {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                        Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
        }
}

Console.Write("Введите желаемое кол-во строк в массиве: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите желаемое кол-во столбцов в массиве: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[,] array = GetSpiralArray(n, m);
Console.WriteLine();

PrintArray(array);

