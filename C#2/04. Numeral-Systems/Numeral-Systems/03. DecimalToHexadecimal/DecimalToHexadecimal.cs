using System;


namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static string hexNumbers = "0123456789ABCDEF";

        static string DecToHex(ulong decValue)
        {
            string hexValue = string.Empty;

            do
            {
                int hex = Convert.ToInt32(decValue % 16);
                hexValue = hexNumbers[hex] + hexValue;
                decValue /= 16;
            } while (decValue != 0);

            return hexValue;
        }
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());

            Console.WriteLine(DecToHex(N));
        }
    }
}
