using System;
using System.Globalization;   // needed for Regex
using System.Text.RegularExpressions;   // needed for CultureInfo and DateTimeStyles

class DatesFromTextInCanada
{
    static void Main()
    {
        //string text = Console.ReadLine();
        // for faster testing
        string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

        Console.WriteLine("Extracted dates from the sample text: ");

        foreach (Match item in Regex.Matches(text, @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}"))
        {
            DateTime date;

            if (DateTime.TryParseExact(item.Value, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }

        Console.WriteLine();
    }
}






//namespace _19.DatesFromTextInCanada
//{
//    using System;
//    using System.Globalization;
//    using System.Threading;
//    class DatesFromTextInCanada
//    {
//        static void Main()
//        {
//            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");
//            //                CultureInfo.CreateSpecificCulture("en-CA");

//            string[] words = Console.ReadLine()
//                .Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

//            foreach (var word in words)
//            {
//                if (isDate(word))
//                {
//                    DateTime date = DateTime.Parse(word);
//                    Console.WriteLine("{0}", word.ToString(new CultureInfo("en-CA")));
//                }
//            }
//        }

//        static bool isDate(string text)
//        {
//            try
//            {
//                DateTime date = DateTime.Parse(text);
//                return true;
//            }
//            catch (FormatException)
//            {
//                return false;
//            }
//        }
//    }
//}


//using System;
//using System.Globalization;
//using System.Threading;
//using System.Text.RegularExpressions;

//namespace _19_Dates_From_Text_Canada
//{
//    class DatesFromCanada
//    {
//        static void Main(string[] args)
//        {
//            // https://en.wikipedia.org/wiki/Date_and_time_notation_in_Canada
//            // YYYY MM DD

//            // Set culture to Canada - en-CA.
//            Thread.CurrentThread.CurrentCulture =
//                CultureInfo.CreateSpecificCulture("en-CA");

//            // Input.
//            var toParse = Console.ReadLine();

//            // Extract all dates.
//            var datePattern = @"(\d{2}\.\d{2}\.\d{4}).*?";
//            var dateRegex = new Regex(datePattern);

//            var dateMatches = dateRegex.Matches(toParse);

//            //var dates = new List<DateTime>();

//            foreach (var date in dateMatches)
//            {
//                // Convert to DateTime
//                var thisDate =
//                    DateTime.Parse(date.ToString());

//                Console.WriteLine(
//                    thisDate.ToString("MMMM dd yyyy"));
//            }
//        }
//    }
//}

