﻿using System;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
