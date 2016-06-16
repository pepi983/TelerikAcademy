namespace _8_11.Matrix
{
    class StartUp
    {
        static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(1, 1);
            Matrix<int> secondMatrix = new Matrix<int>(3, 4);

            for (int i = 0; i < secondMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    secondMatrix[i, j] = i*4 + j + 1;
                }
            }

            System.Console.WriteLine(secondMatrix);
        }
    }
}
