using System;


namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {

        static int GetMax(int firstNumber, int secondNumer)
        {
            if(firstNumber > secondNumer)
            {
                return firstNumber;
            }

            return secondNumer;
        }

        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');

            int max = GetMax(int.Parse(numbers[0]), int.Parse(numbers[1]));

            max = GetMax(max, int.Parse(numbers[2]));

            Console.WriteLine(max);
        }
    }
}
