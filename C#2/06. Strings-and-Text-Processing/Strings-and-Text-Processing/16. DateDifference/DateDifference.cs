namespace _16.DateDifference
{
    using System;
    using System.Globalization;

    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter the first date: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the second date: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Distance: {0} days", Math.Abs((secondDate - firstDate).Days));
        }
    }
}
