double[] MakeCubeOfNumber(int number)
{
        double[] cubeNumbers = new double[number];

        for(int i = 0; i < number; i++)
        {
                cubeNumbers[i] = Math.Pow(i + 1, 3);
        }

        return cubeNumbers;
}


Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

double[] result = MakeCubeOfNumber(n);

for (int i = 0; i < result.Length; i++)
{
        Console.WriteLine(result[i]);
}



