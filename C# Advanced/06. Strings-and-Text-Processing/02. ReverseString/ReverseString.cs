namespace _02.ReverseString
{
    using System;
    using System.Text;
    class ReverseString
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var reverseText = new StringBuilder(text.Length);

            foreach (var letter in text)
            {
                reverseText.Insert(0, letter);
            }

            Console.WriteLine(reverseText);
        }
    }
}
