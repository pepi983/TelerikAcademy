using System;


namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a = dole.Parse(Console.ReadLine());
            double b = dole.Parse(Console.ReadLine());
            double c = dole.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a == 0 || b == 0 || c==0)
            {
                Console.WriteLine("0");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
