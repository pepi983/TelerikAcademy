namespace _03.CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int openBrackets = 0;
            int closeBrackets = 0;

            foreach (char symbol in text)
            {
                if(symbol == '(')
                {
                    openBrackets++;
                }

                if(symbol == ')')
                {
                    closeBrackets++;
                }
            }

            Console.WriteLine("{0}", openBrackets == closeBrackets ? "Correct" : "Incorrect" );
        }
    }
}
