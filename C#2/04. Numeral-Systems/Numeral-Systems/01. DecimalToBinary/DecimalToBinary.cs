using System;


namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {
        static string DecToBinary(ulong decValue)
        {
            string binary = string.Empty;

            do
            {
                ulong bit = decValue % 2;
                binary = bit + binary;
                decValue = decValue / 2;

            } while (decValue != 0);

            return binary;
        }
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());

            Console.WriteLine(DecToBinary(N));
        }
    }
}
