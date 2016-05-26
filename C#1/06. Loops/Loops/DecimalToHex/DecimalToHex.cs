using System;


namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());
            string hex = "";
            int  number;

            while(N > 0)
            {
                number = (int)(N % 16);
                if(number == 10)
                {
                    hex = "A" + hex;
                }
                else if (number == 11)
                {
                    hex = "B" + hex;
                }
                else if (number == 12)
                {
                    hex = "C" + hex;
                }
                else if (number == 13)
                {
                    hex = "D" + hex;
                }
                else if (number == 14)
                {
                    hex = "E" + hex;
                }
                else if (number == 15)
                {
                    hex = "F" + hex;
                }
                else
                {
                    hex = number + hex;
                }
                N /= 16;

            }
            Console.WriteLine(hex);
        }
    }
}
