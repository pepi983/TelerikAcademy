namespace _09.ForbiddenWords
{
    using System;
    using System.Text;
    class ForbiddenWords
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var censoredText = new StringBuilder(text.Length);

            censoredText.Append(text);

            foreach (var word in words)
            {
                censoredText.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(censoredText);
        }
    }
}
