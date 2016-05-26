using System;
using System.Collections.Generic;


namespace SubsetKWithSumS
{
    class SubsetKWithSumS
    {
        public static string[] Combination(string[] str)
        {
           

            if (str.Length == 1)
                return str;

            // read the last character
            string c = str[str.Length - 1];

            // apart from the last character send remaining string for further processing
            Array.Resize(ref str, str.Length - 1);
            string[] returnArray = Combination(str);

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


            string[] array = new string[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = Console.ReadLine();
            }

            int K = int.Parse(Console.ReadLine());

            int S = int.Parse(Console.ReadLine());
            int chek = 0;
            int sum = 0;

            string[] newArray = Combination(array);

            foreach (string item in newArray)
            {

                if (item.Length == K)
                {
                    for (int i = 0; i < K; i++)
                    {
                        sum += item[i] - '0';
                    }
                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        chek = 1;
                        break;
                    }
                }
                sum = 0;
            }

            if (chek == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}

// This is only for string
//public string[] Combination(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        throw new ArgumentException("Invalid input");

//    if (str.Length == 1)
//        return new string[] { str };

//    // read the last character
//    char c = str[str.Length - 1];

//    // apart from the last character send remaining string for further processing
//    string[] returnArray = Combination(str.Substring(0, str.Length - 1));

//    // List to keep final string combinations
//    List<string> finalArray = new List<string>();

//    // add whatever is coming from the previous routine
//    foreach (string s in returnArray)
//        finalArray.Add(s);

//    // take the last character
//    finalArray.Add(c.ToString());

//    // take the combination between the last char and the returning strings from the previous routine
//    foreach (string s in returnArray)
//        finalArray.Add(s + c);

//    return finalArray.ToArray();
//}