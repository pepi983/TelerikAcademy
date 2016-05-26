using System;
using System.Collections.Generic;
using System.Text;

namespace _21.CombinationsOfSet
{
    class CombinationsOfSet
    {
        public static string[] Combination(string str)
        {
            if (str.Length == 1)
                return new string[] { str };

            // read the last character
            char c = str[str.Length - 1];

            // apart from the last character send remaining string for further processing
            string[] returnArray = Combination(str.Substring(0, str.Length - 1));

            // List to keep final string combinations
            List<string> finalArray = new List<string>();

            // add whatever is coming from the previous routine
            foreach (string s in returnArray)
                finalArray.Add(s);

            // take the last character
            finalArray.Add(c.ToString());

            // take the combination between the last char and the returning strings from the previous routine
            foreach (string s in returnArray)
                finalArray.Add(s + c);

            return finalArray.ToArray();
        }
        static void Main()
        {
            
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            string str = "";

            for (int i = 1; i <= N; i++)
            {
                str = str + i.ToString();
            }

            string[] array = Combination(str);

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    string alabala = array[i];
                    if (array[i].Length == K)
                    {
                        if (j == 0)
                        {
                            Console.Write("{");
                            Console.Write("{0}, ", alabala[j]);
                        }
                        else if (j == array[i].Length - 1)
                        {
                            Console.Write("{0}", alabala[j]);
                            Console.Write("}");
                        }
                        else
                        {
                            Console.Write("{0}, ", alabala[j]);
                            
                        }
                    }
                }
                if (array[i].Length == K)
                    Console.WriteLine();
            }
        }
    }
}
