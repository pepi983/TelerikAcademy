using System;


namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static string ReverseDigits(string number)
        {
            string reversedNumber = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {
                reversedNumber = number[i] + reversedNumber;
            }

            return reversedNumber;
        }
        static void Main()
        {
            string getNumber = Console.ReadLine();

            Console.WriteLine(ReverseDigits(getNumber));
        }
    }
}
