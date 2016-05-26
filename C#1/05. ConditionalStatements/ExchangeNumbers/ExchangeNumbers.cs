using System;


namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            if(A > B)
            {
                A = A + B;
                B = A - B;
                A = A - B;
            }

            Console.WriteLine("{0} {1}", A, B);
        }
    }
}
