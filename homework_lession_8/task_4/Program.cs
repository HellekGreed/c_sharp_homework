void PrintArray(int[,,] array)
{
        for(int i = 0; i < array.GetLength(2); i++)
        {
                for(int j = 0; j < array.GetLength(0); j++)
                {
                        for(int k = 0; k < array.GetLength(1); k++)
                        {
                                Console.Write($"| {array[j,k,i]}({j},{k},{i}) |");
                        }
                        Console.WriteLine();
                }
                Console.WriteLine();
        }
}

int[,,] array = new int[3, 3, 3] {{{10,11,12}, {20,21,22}, {30,31,32}},
                                  {{40,41,42}, {50,51,52}, {60,61,62}},
                                  {{70,71,72}, {80,81,82}, {90,91,92}}};

PrintArray(array);

