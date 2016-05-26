using System;
using System.Linq;
using System.Numerics;
namespace _12.IntegerCalculations
{
    class IntegerCalculations
    {

        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            PrintTheSmallestElement(numbers);

            PrintTheBiggestElement(numbers);

            PrintTheAverage(numbers);

            PrintTheSum(numbers);

            PrintTheProduct(numbers);
        }
        static void PrintTheSmallestElement(int[] numbers)
        {
            int minValue = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < minValue)
                {
                    minValue = number;
                }
            }

            Console.WriteLine(minValue);
        }

        static void PrintTheBiggestElement(int[] numbers)
        {
            int maxValue = int.MinValue;

            foreach (int number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            Console.WriteLine(maxValue);
        }

        static void PrintTheAverage(int[] numbers)
        {
            double average;
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            average = (double)sum / numbers.Length;

            Console.WriteLine("{0:F2}", average);
        }

        static void PrintTheSum(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        static void PrintTheProduct(int[] numbers)
        {
            BigInteger product = 1;

            foreach (int number in numbers)
            {
                product *= number;
            }

            Console.WriteLine(product);
        }
    }
}
