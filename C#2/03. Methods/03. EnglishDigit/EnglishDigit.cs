using System;



namespace _03.EnglishDigit
{
    class EnglishDigit
    {

        static void PrintEnglishWord(int number)
        {
            string[] englishNumbers = "zero one two three four five six seven eight nine ten".Split(' ');

            int digit = number % 10;

            Console.WriteLine(englishNumbers[digit]);
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintEnglishWord(number);
        }
    }
}
