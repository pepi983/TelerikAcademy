namespace _02.EnterNumbers
{
    using System;
    using System.Linq;

    class EnterNumbers
    {
        
        static void Main()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            ReadNumbers(0, 100, numbers);

        }

        static bool IsSorted(int[] numbers)
        {

            for (int i = 1; i < 10; i++)
            {
                if (numbers[i - 1].CompareTo(numbers[i]) != -1)
                {
                    return false;
                }
            }

            return true;
        }

        static void ReadNumbers(int start, int end, int[] numbers)
        {
            try
            {
                if (!IsSorted(numbers) || numbers.Any( x => x < start) || numbers.Any( x => x > end))
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("1 < " + string.Join(" < ", numbers) + " < 100");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }


    }
}
