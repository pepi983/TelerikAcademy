using System;

    class Divide
    {
        static void Main(string[] args)
        {
        int NUMBER = int.Parse(Console.ReadLine());
        bool a = (NUMBER % 7 == 0) && (NUMBER % 5 == 0);
   
        if (a)
        {
            Console.WriteLine("true {0}", NUMBER);
        }
        else
        {
            Console.WriteLine("false {0}", NUMBER);
                
        }

        }
    }

