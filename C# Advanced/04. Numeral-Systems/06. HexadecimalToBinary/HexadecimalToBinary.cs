using System;
using System.Collections.Generic;
using System.Numerics;


namespace _06.HexadecimalToBinary
{
    class HexadecimalToBinary
    {

        static Dictionary<char, string> hexBin = new Dictionary<char, string>()
        {
            {'0', "0000"},
            {'1', "0001"},
            {'2', "0010"},
            {'3', "0011"},
            {'4', "0100"},
            {'5', "0101"},
            {'6', "0110"},
            {'7', "0111"},
            {'8', "1000"},
            {'9', "1001"},
            {'A', "1010"},
            {'B', "1011"},
            {'C', "1100"},
            {'D', "1101"},
            {'E', "1110"},
            {'F', "1111"}
        };


        static string HexToBin(string hexValue)
        {
            string binValue = string.Empty;

            foreach (char hex in hexValue)
            {
                binValue += hexBin[hex];
            }

            return binValue;
        }

        static void Main()
        {
            string hexNumber = Console.ReadLine();

            Console.WriteLine(BigInteger.Parse(HexToBin(hexNumber)));
        }
    }
}
