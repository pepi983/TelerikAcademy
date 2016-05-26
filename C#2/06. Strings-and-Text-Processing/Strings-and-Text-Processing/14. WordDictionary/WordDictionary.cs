namespace _14.WordDictionary
{
    using System;
    using System.Collections.Generic;
    class WordDictionary
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { ".NET", "platform for applications from Microsoft" },
                { "CLR", "managed execution environment for .NET" },
                { "namespace", "hierarchical organization of classes" }
            };
        static void Main()
        {
            string word = Console.ReadLine();

            Console.WriteLine(dictionary[word]);
        }
    }
}
