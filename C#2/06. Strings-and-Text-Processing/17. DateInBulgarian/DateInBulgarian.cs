namespace _17.DateInBulgarian
{
    using System;
    using System.Globalization;
    class DateInBulgarian
    {
        static void Main()
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            date = date.AddHours(6);
            date = date.AddMinutes(30);

            Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }
}
