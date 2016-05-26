using System;


namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal ha = decimal.Parse(Console.ReadLine());

            decimal surface = (a * ha) / 2;

            Console.WriteLine("{0:0.00}", surface);
        }
    }
}
