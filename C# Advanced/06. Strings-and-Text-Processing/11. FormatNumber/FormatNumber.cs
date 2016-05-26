namespace _11.FormatNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class FormatNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
