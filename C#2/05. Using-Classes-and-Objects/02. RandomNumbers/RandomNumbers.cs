using System;


namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random rng = new Random();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(rng.Next(100, 201));
            }
        }
    }
}
