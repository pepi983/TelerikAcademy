namespace Array.Extensions
{
    using System.Linq;
    public static class ArrayExtension
    {
        public static void PrintDivisibleBy7And3(this int[] arrey)
        {
            var toPrint = arrey
                .Where(x => x % 3 == 0 && x % 7 == 0)
                .ToArray();

            foreach (var number in toPrint)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
