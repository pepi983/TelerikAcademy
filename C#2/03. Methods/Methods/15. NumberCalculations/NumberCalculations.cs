using System;
using System.Linq;

namespace _12.IntegerCalculations
{
    class IntegerCalculations
    {

        static void Main()
        {
            int[] arrayOfInts = { 1, 34, 432, 2, 1 };

            PrintTheSmallestElement(arrayOfInts);
            PrintTheBiggestElement(arrayOfInts);
            PrintTheAverage(arrayOfInts);
            PrintTheSum(arrayOfInts);
            PrintTheProduct(arrayOfInts);

            Console.WriteLine();

            double[] arrayOfDoubles = { 1.1, 34.2, 432.31, -2.4, -1.2 };

            PrintTheSmallestElement(arrayOfDoubles);
            PrintTheBiggestElement(arrayOfDoubles);
            PrintTheAverage(arrayOfDoubles);
            PrintTheSum(arrayOfDoubles);
            PrintTheProduct(arrayOfDoubles);
        }
        static void PrintTheSmallestElement<T>(params T[] numbers)  // if you want to return something "static T TheSmallestElement<T>(params T[] numbers)"
        {
            dynamic minValue = numbers[0];

            foreach (var number in numbers)
            {
                if (number < minValue)
                {
                    minValue = number;
                }
            }

            Console.WriteLine(minValue);
        }

        static void PrintTheBiggestElement<T>(params T[] numbers)
        {
            dynamic maxValue = numbers[0];

            foreach (var number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            Console.WriteLine(maxValue);
        }

        static void PrintTheAverage<T>(params T[] numbers)
        {
            
            dynamic sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("{0:F2}", (double)sum / numbers.Length);
        }

        static void PrintTheSum<T>(params T[] numbers)
        {
            dynamic sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        static void PrintTheProduct<T>(params T[] numbers)
        {
            dynamic product = 1;

            foreach (var number in numbers)
            {
                product *= number;
            }

            Console.WriteLine(product);
        }
    }
}
