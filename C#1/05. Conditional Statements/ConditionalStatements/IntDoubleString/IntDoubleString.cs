using System;


namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string tip = Console.ReadLine();
            string value = Console.ReadLine();

            switch(tip)
            {
                case "integer":
                    {
                      int a = int.Parse(value);
                        Console.WriteLine(a + 1); break;
                    }
                case "real":
                    {
                        double a = double.Parse(value);
                        Console.WriteLine("{0:F2}", a + 1); break;
                    }
                default: Console.WriteLine("{0}*", value); break;
            }

        }
    }
}
