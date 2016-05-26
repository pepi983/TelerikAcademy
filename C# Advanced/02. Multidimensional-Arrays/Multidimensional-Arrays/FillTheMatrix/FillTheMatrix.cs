using System;


namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            switch (letter)
            {
                case 'a':
                    for (int i = 0; i < N; i++)

                    {
                        for (int j = 0; j < N; j++)
                        {
                            matrix[j, i] = i * N + j + 1;
                        }
                    }
                    break;

                case 'b':
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            if (j % 2 == 0)
                            {
                                matrix[i, j] = j * N + i + 1;
                            }
                            else
                            {
                                matrix[i, j] = j * N + N - i;
                            }
                        }
                    }
                    break;

                case 'c':
                    int r = N - 1;
                    int c = 0;
                    int mod = 1;

                    for (int i = 0; i < N * N; i++)
                    {
                        if (r == N && c < N)
                        {
                            mod++;
                            r = N - mod;
                            c = 0;
                        }
                        else if (c == N && c <= N)
                        {
                            mod--;
                            r = 0;
                            c = N - mod;
                        }

                        matrix[r, c] = i + 1;
                        r++;
                        c++;
                    }
                    break;

                case 'd':
                    matrix = SpiralMatrix(matrix, N);
                    break;

                default:
                    break;
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j != N - 1)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        private static int[,] SpiralMatrix(int[,] matrix, int N)
        {
            string direction = "down";
            int row = 0;
            int col = 0;


            for (int i = 1; i <= N * N; i++)
            {
                if (direction == "down" && (row > N - 1 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row--;
                    col++;
                }

                if (direction == "right" && (col > N - 1 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                }

                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--;
                }

                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "down";
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
            return matrix;
        }
    }
}

