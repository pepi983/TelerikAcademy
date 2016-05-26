using System;
using System.Collections.Generic;


namespace _04.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {

        static Dictionary<char, int> hexDec = new Dictionary<char, int>()
        {
            {'0', 0 },
            {'1', 1 },
            {'2', 2 },
            {'3', 3 },
            {'4', 4 },
            {'5', 5 },
            {'6', 6 },
            {'7', 7 },
            {'8', 8 },
            {'9', 9 },
            {'A', 10 },
            {'B', 11 },
            {'C', 12 },
            {'D', 13 },
            {'E', 14 },
            {'F', 15 }
        };

        static ulong HexToDec(string hexValue)
        {
            ulong DecValue = 0;

            foreach (char hex in hexValue)
            {
                DecValue = Convert.ToUInt64(hexDec[hex]) + DecValue * 16;
            }

            return DecValue;
        }

        static void Main()
        {
            string hexNumber = Console.ReadLine();

            Console.WriteLine(HexToDec(hexNumber));
        }
    }
}
