using System;


namespace _01.SayHello
{
    class SayHello
    {

        static void Print(string firstName)
        {
            Console.WriteLine("Hello, {0}!", firstName);
        }

        static void Main()
        {
            string userName = Console.ReadLine();

            Print(userName);
        }
    }
}
