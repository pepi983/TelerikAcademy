using System;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(' ');

            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }


            int bestSum = int.MinValue;
            int sum;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] 
                        + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2] ;
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                    sum = 0;
                }
            }

            Console.WriteLine(bestSum);

        }
    }
}
