namespace Array
{
    using System;
    using System.Linq;
    using Array.Extensions;
    class StartUp
    {
        static void Main()
        {
            var arrayOfNumbers = new int[] { 1, 3, 6, 11, 14, 18, 21, 28, 42 };
            arrayOfNumbers.PrintDivisibleBy7And3();


            Console.WriteLine(new string('-', 10));
            System.Console.WriteLine();


            var filteredArray = arrayOfNumbers
                .Where(x => x % 3 == 0 && x % 7 == 0)
                .ToList();

            foreach (var number in filteredArray)
            {
                System.Console.WriteLine(number);
            }


            Console.WriteLine(new string('-', 10));
            System.Console.WriteLine();
        }
    }
}
