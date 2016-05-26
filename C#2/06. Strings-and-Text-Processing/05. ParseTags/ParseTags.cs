namespace _05.ParseTags
{
    using System;
    using System.Collections.Generic;
    class ParseTags
    {
        static List<int> FindIndex(string text)
        {
            var indices = new List<int>();

            int indexStart = text.IndexOf("<upcase>", 0);
            int indexEnd = 0;

            while (indexStart != -1 && indexEnd != -1)
            {
                indices.Add(indexStart);

                indexEnd = text.IndexOf("/upcase", indexStart);

                indices.Add(indexEnd);

                indexStart = text.IndexOf("<upcase>", indexEnd + 1);
            }

            return indices;
        }
        static string ParseText(string text)
        {
            string parsedText = text;
            var indices = FindIndex(text);

            string textForChange = string.Empty;
            string changedText = string.Empty;

            for (int i = 0; i < indices.Count; i += 2)
            {
                textForChange = text.Substring(indices[i], indices[i + 1] - indices [i] + 8);

                changedText = text.Substring(indices[i] + 8, textForChange.Length - 17).ToUpper();      // vzimame samo tova koeto e mejdu tagovete

                parsedText = parsedText.Replace(textForChange, changedText);
            }

                return parsedText;
        }
        static void Main()
        {
            string text = Console.ReadLine();

            text = ParseText(text);

            Console.WriteLine(text);
        }
    }
}

