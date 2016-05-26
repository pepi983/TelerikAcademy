using System;

class OddOrEven
{
    static void Main()
    {
        int NUMBER = int.Parse(Console.ReadLine());
        if (NUMBER % 2 == 0)
        {
            Console.WriteLine("even" + " " + NUMBER);
        }
        else
        {
            Console.WriteLine("odd" + " " + NUMBER);
        }
    }
}

