using System;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static ulong BinaryToDec(string binary)
        {
            ulong decValue = 0;

            foreach (char bit in binary)
            {                
                decValue = Convert.ToUInt64(bit - '0') + decValue * 2;
            }

            return decValue;
        }
        static void Main()
        {
            string N = Console.ReadLine();

            Console.WriteLine(BinaryToDec(N));
        }
    }
}
