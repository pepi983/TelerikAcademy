using System;
using System.Linq;

namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static int FirstLargerElement(int[] array, int arraySize)
        {
            

            for (int i = 1; i <= arraySize - 2; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            Console.WriteLine(FirstLargerElement(array, N));
        }
    }
}
