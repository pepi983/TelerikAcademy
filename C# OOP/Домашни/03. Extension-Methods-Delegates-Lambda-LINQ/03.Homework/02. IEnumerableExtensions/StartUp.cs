namespace IEnumerable
{
    using IEnumerable.Extensions;
    class StartUp
    {
        static void Main()
        {
            var arrey = new int[]{ 1, 2, 5, 8 };

            System.Console.WriteLine(arrey.Average());
        }
    }
}
