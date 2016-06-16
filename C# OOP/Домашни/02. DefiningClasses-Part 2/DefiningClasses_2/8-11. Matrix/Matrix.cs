namespace _8_11.Matrix
{
    using System;
    using System.Text;
    public class Matrix<T> where T : struct, IComparable, IComparable<T>, 
                  IConvertible, IEquatable<T>, IFormattable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Rows must be more than zero!");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Columns must be more than zero!");
                }
                this.cols = value;
            }
        }
        public T this[int indexRow, int indexCol]
        {
            get
            {
                if (indexRow < 0 || indexRow >= rows)
                {
                    throw new IndexOutOfRangeException("Row are out of range!");
                }
                else if (indexCol < 0 || indexCol >= cols)
                {
                    throw new IndexOutOfRangeException("Colum are out of range!");
                }

                return this.matrix[indexRow, indexCol];
            }
            set
            {
                if (indexRow < 0 || indexRow >= rows)
                {
                    throw new IndexOutOfRangeException("Row are out of range!");
                }
                else if (indexCol < 0 || indexCol >= cols)
                {
                    throw new IndexOutOfRangeException("Colum are out of range!");
                }

                this.matrix[indexRow, indexCol] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Cannot addition matrices with different sizes!");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    newMatrix[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Cannot substract matrices with different sizes!");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    newMatrix[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("The colums of first matrix must be equal to rows of second matrix!");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.rows, secondMatrix.Cols);

            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.Cols; j++)
                {
                    for (int k = 0; k < secondMatrix.Rows; k++)
                    {
                        newMatrix[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                    }
                }
            }

            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !(Matrix<T> matrix)
        {
            if (matrix)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            var toString = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    toString.AppendFormat("{0, 5}", matrix[i, j]);
                }
                toString.Append("\n");
            }

            return toString.ToString();
        }
    }
}
