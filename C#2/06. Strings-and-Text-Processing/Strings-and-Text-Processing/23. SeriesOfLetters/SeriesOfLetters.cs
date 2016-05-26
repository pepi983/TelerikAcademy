namespace _23.SeriesOfLetters
{
    using System;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            string text = Console.ReadLine();

            var newText = new StringBuilder();

            newText.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i-1])
                {
                    newText.Append(text[i]);
                }
            }

            Console.WriteLine(newText);
        }
    }
}
