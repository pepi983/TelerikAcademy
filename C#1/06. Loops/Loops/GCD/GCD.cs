using System;

namespace GCD
{
    class GCD // nai golqm obsht delitel
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            int A = Math.Abs(int.Parse(input[0]));
            int B = Math.Abs(int.Parse(input[1]));
            int br = 1;

            while ( !(br == 0) )
            {
                
                br = A % B;
                A = B;
                B = br;
            }
            Console.WriteLine(A);
        }
    }
}
