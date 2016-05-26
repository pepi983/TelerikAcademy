using System;
using System.Linq;

namespace _08.SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
           int[] numbers = Console
                               .ReadLine()
                               .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(item => int.Parse(item))
                               .ToArray();

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
