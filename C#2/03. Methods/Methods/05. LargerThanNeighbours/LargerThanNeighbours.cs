using System;
using System.Linq;


namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {

        static int CountLargerNumbers(int[] array, int arraySize)
        {
            int counter = 0;

            for (int i = 1; i <= arraySize - 2; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            Console.WriteLine(CountLargerNumbers(array, N));
        }
    }
}
