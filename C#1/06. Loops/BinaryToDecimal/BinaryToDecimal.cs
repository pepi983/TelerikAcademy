using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int n = input.ToString().Length -1;
            double sum = 0;
            int br = 0;
            double pow;
           

            for(int  i = n; i >=0; i--)
            {
                if (input[br] == '1')
                {
                    pow = Math.Pow(2, i);
                    sum += (pow * 1);
                    
                }
                br++;



            }
            Console.WriteLine(sum);
        }
    }
}
