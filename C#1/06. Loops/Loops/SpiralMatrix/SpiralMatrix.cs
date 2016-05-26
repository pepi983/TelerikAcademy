using System;


namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {



            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int col = 0;
            int row = 0;
            int maxRotation = N * N;
            string direction = "right";

            for (int i = 1; i <= maxRotation; i++)
            {
                if (direction == "right" && (col > N - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }

                if (direction == "down" && (row > N - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }

                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "right";
                    col++;
                    row++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }

                if (direction == "down")
                {
                    row++;
                }

                if (direction == "left")
                {
                    col--;
                }

                if (direction == "up")
                {
                    row--;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }



        }
    }
}



