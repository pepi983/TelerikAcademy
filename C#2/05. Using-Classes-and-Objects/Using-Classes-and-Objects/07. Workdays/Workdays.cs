using System;
using System.Collections.Generic;

namespace _07.Workdays
{
    class Workdays
    {

        static void Main()
        {
            Console.Write("Enter Date in format dd.mm.yyyy: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Today;

            int currentYear = now.Year;

            List<DateTime> holidays = new List<DateTime>() { new DateTime(2016, 5, 23),
            new DateTime(2016, 5, 24), new DateTime(2016, 9, 5), new DateTime(2016, 9, 6),
            new DateTime(2016, 9, 22), new DateTime(2016, 9, 23), new DateTime(2016, 12, 26) };

            int workDays = 0;

            while (now <= date)
            {
                if ((int)now.DayOfWeek != 6 && (int)now.DayOfWeek != 0 && !(holidays.Contains(now)))
                {
                    workDays++;
                }
                
                now = now.AddDays(1);
            }

            Console.WriteLine(workDays);
        }
    }
}
