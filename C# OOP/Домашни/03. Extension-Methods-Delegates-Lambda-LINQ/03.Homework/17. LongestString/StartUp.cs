namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var stringsList = new List<string>() { "a", "ab", "abc", "abcd" };

            var longestString = stringsList
                .First(str => str.Length == stringsList.Max(st => st.Length));

            Console.WriteLine(longestString);
        }
    }
}
