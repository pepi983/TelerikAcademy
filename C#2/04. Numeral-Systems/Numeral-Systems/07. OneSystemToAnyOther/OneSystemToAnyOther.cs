﻿using System;
using System.Collections.Generic;
using System.Numerics;


namespace _07.OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {


        static Dictionary<char, int> decDigits = new Dictionary<char, int>()
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
        static ulong NToDec(string binary, int sBase)
        {
            ulong decValue = 0;

            foreach (char digit in binary)
            {
                decValue = Convert.ToUInt64(decDigits[char.ToUpper(digit)]) + decValue * Convert.ToUInt64(sBase);
            }

            return decValue;
        }


        static string baseDigits = "0123456789ABCDEF";

        static string NToD(ulong decValue, int dBase)
        {
            string dValue = string.Empty;

            do
            {
                int digit = Convert.ToInt32(decValue % Convert.ToUInt64(dBase));
                dValue = baseDigits[digit] + dValue;
                decValue /= Convert.ToUInt64(dBase);
            } while (decValue != 0);

            return dValue;
        }

        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            string N = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine(NToD(NToDec(N, s), d));
        }
    }
}
