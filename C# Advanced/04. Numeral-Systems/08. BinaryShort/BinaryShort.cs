using System;


namespace _08.BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());

            string binary = Convert.ToString(N, 2).PadLeft(16, '0');

            Console.WriteLine(binary);              
        }
    }
}
