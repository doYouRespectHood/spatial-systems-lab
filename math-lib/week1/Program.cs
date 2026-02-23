using System;

class Program
{
        static void Main()
        {
            double[,] matrix =
        {
            {1, 0, 0},
            {0, 2, 0},
            {0, 0, 3}
        };
        
        double[] vector = {1, 1, 1};
        double[] result = new double[3];

        for (int i = 0; i <3; i++)
        {
            result[i] = 0;
            for (int j = 0; j < 3; j++)
            {
                result[i] += matrix[i, j] * vector [j];
            }
        }

        Console.WriteLine($"Result: [{result[0]}, {result[1]}, {result[2]}]");
        }
}