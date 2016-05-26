using System;
using System.Linq;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static int CountAppearance(int number, int[] array)
        {
            int counter = 0;

            foreach (var element in array)
            {
                if(element == number)
                {
                    counter++;
                }
            }

            return counter;
        }
        static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CountAppearance(number, array));
        }
    }
}
