namespace _04.Sub_StringInText
{
    using System;
    class SubStringInText
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int counter = 0;
            int index = 0;

            while (text.IndexOf(pattern, index) != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index) + 1;
            }

            Console.WriteLine(counter);
        }
    }
}
