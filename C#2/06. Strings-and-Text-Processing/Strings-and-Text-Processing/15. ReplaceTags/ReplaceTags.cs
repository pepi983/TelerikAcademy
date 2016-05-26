namespace _15.ReplaceTags
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ReplaceTags
    {


        static void Main()
        {
            string text = Console.ReadLine();
            //string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            var tagIndeces = startEndIndeces(text);
            var textIndeces = textIndex(text, tagIndeces);
            var urlIndeces = urlIndex(text);

            var replacedText = new StringBuilder();

            replacedText.Append(text.Substring(0, tagIndeces[0] ));

            for (int i = 0; i < tagIndeces.Count; i += 2)
            {

                if (replacedText.ToString() != text.Substring(0, tagIndeces[0] ))
                {
                    replacedText.Append(text.Substring(tagIndeces[i - 1] , tagIndeces[i] - tagIndeces[i - 1]));
                }

                replacedText.Append("[" + text.Substring(textIndeces[i], textIndeces[i + 1] - textIndeces[i]) + "]");
          
                replacedText.Append("(" + text.Substring(urlIndeces[i], urlIndeces[i + 1] - urlIndeces[i]) + ")");

                if ((i + 2) >= tagIndeces.Count)
                {
                    replacedText.Append(text.Substring(tagIndeces[i + 1], text.Length - tagIndeces[i + 1]));
                }
            }

            Console.WriteLine(replacedText);

        }
        static List<int> startEndIndeces(string text)
        {
            var startEndIndeces = new List<int>();

            int indexStart = text.IndexOf("<a", 0);
            int indexEnd = 0;

            while (indexStart != -1 && indexEnd != -1)
            {
                startEndIndeces.Add(indexStart);

                indexEnd = text.IndexOf("</a>", indexStart) + 4;

                startEndIndeces.Add(indexEnd);

                indexStart = text.IndexOf("<a", indexEnd + 1);
            }

            return startEndIndeces;
        }

        static List<int> textIndex(string text, List<int> openTags)
        {
            var textIndex = new List<int>();

            int openTagsIndeces = 0;
            int indexStart = text.IndexOf(">", openTags[openTagsIndeces]) + 1;
            int indexEnd = 0;

            for (int i = 0; i < openTags.Count; i += 2)
            {
                indexStart = text.IndexOf(">", openTags[openTagsIndeces]) + 1;
                if (indexStart == 0)
                {
                    break;
                }

                textIndex.Add(indexStart);

                indexEnd = text.IndexOf("</", indexStart);

                textIndex.Add(indexEnd);

                openTagsIndeces += 2;
            }

            return textIndex;
        }

        static List<int> urlIndex(string text)
        {
            var urlIndex = new List<int>();

            int indexStart = text.IndexOf("href=\"", 0) + 6;
            int indexEnd = 0;

            while (indexStart != 5 && indexEnd != -1)
            {
                urlIndex.Add(indexStart);

                indexEnd = text.IndexOf("\"", indexStart + 6);

                urlIndex.Add(indexEnd);

                indexStart = text.IndexOf("href=\"", indexEnd + 1) + 6;
            }

            return urlIndex;
        }

    }
}
