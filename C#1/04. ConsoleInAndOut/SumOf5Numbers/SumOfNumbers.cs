using System;


namespace SumOf5Numbers
{
    class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", number1 + number2 + number3 + number4 + number5);
        }
    }
}
