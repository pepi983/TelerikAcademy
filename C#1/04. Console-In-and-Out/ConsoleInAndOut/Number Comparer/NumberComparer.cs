using System;

namespace Number_Comparer
{
    class NumberComparer
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double greater = Math.Max(A, B); // приема стойноста на по-голямото число

            Console.WriteLine(greater);

        }
    }
}
