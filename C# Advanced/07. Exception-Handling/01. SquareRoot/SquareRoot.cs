namespace _01.SquareRoot
{
    using System;
   
    class SquareRoot
    {
        static void Sqrt(string number)
        {
            double sqrtNumber;

            
            try
            {
                sqrtNumber = double.Parse(number);
                if (sqrtNumber >= 0)
                {
                    sqrtNumber = Math.Sqrt(sqrtNumber);
                    Console.WriteLine("{0:F3}", sqrtNumber);
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
        static void Main()
        {
            Sqrt(Console.ReadLine());
        }
    }
}
