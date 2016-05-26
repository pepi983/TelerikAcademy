using System;


namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string binary = Convert.ToString(a, 2).PadLeft(10, '0');      // Conver a to binary number and padded with zeroes 

            Console.WriteLine("{0, -10:X} |{1:}| {2, 10:0.00}|{3, -10:0.000}|", a, binary, b, c);    // -10 - left aligned and 10 - right aligned
        }
    }
}
