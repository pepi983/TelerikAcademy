using System;


namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
         
            long N = long.Parse(Console.ReadLine());
            string binary = "";
            

            if (N == 0)
            {
                binary = "0";
            }
            else
            {
                
                while (N > 0)
                {
                    if (N % 2 == 0)
                    {
                        binary = "0" + binary;
                    }
                    else
                    {
                        binary = "1" + binary;
                    }
                    N /= 2;
                }
            }
            Console.WriteLine(binary);
        }
    }
}
