using System;

class LongSequence
{
    static void Main()
    {
        int number = -1;
        int f = -1;


        for (int i = 0; i < 1000; i++)
        {

            number = -(number + f);
            Console.WriteLine(number);
            f = -f;

        }

    }
}
