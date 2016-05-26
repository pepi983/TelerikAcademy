using System;
using System.Collections.Generic;

namespace _05.BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {

        static Dictionary<string, char> binHex = new Dictionary<string, char>()
                {
                    {"0000", '0' },
                    {"0001", '1' },
                    {"0010", '2' },
                    {"0011", '3' },
                    {"0100", '4' },
                    {"0101", '5' },
                    {"0110", '6' },
                    {"0111", '7' },
                    {"1000", '8' },
                    {"1001", '9' },
                    {"1010", 'A' },
                    {"1011", 'B' },
                    {"1100", 'C' },
                    {"1101", 'D' },
                    {"1110", 'E' },
                    {"1111", 'F' }
                };


        static string BinToHex(string binValue)
        {
            string hexValue = string.Empty;

            for (int i = binValue.Length - 1; i >= 0; i--)
            {
                string fourBits = Convert.ToString(binValue[i]);
                i--;

                if (i < 0)
                {
                    fourBits = "000" + fourBits;
                }
                else
                {
                    fourBits = Convert.ToString(binValue[i]) + fourBits;
                    i--;

                    if (i < 0)
                    {
                        fourBits = "00" + fourBits;
                    }
                    else
                    {
                        fourBits = Convert.ToString(binValue[i]) + fourBits;
                        i--;
                        if (i < 0)
                        {
                            fourBits = "0" + fourBits;
                        }
                        else
                        {
                            fourBits = Convert.ToString(binValue[i]) + fourBits;
                        }
                    }
                }

                hexValue = Convert.ToString(binHex[fourBits]) + hexValue;
            }

            return hexValue;
        }

        static void Main()
        {
            string binary = Console.ReadLine();

            Console.WriteLine(BinToHex(binary));
        }
    }
}

//static ulong BinaryToDec(string binary)
//{
//    ulong decValue = 0;

//    foreach (char bit in binary)
//    {
//        decValue = Convert.ToUInt64(bit - '0') + decValue * 2;
//    }

//    return decValue;
//}

//static string hexNumbers = "0123456789ABCDEF";

//static string DecToHex(ulong decValue)
//{
//    string hexValue = string.Empty;

//    do
//    {
//        int hex = Convert.ToInt32(decValue % 16);
//        hexValue = hexNumbers[hex] + hexValue;
//        decValue /= 16;
//    } while (decValue != 0);

//    return hexValue;
//}

//static void Main()
//{
//    string binary = Console.ReadLine();

//    Console.WriteLine(DecToHex(BinaryToDec(binary)));
//}
