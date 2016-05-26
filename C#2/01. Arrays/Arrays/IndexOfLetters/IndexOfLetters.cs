using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] array = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                int left = 0;
                int right = array.Length;
                int result = 0;

                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (array[middle] == word[i])
                    {
                        result = middle;
                        break;
                    }
                    else if (array[middle] > word[i])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
