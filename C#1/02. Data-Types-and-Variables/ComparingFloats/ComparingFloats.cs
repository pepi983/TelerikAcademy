using System;
    class ComparingFloats
  {
        static void Main()
        {
        float eps = 0.000001f;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        a = a / eps;
        int c = (int)a;
        b = b / eps;
        int d = (int)b;
        
        if (c == d)
         {
            Console.WriteLine("true");
         }
         else Console.WriteLine("false");

        

      


    }
    }

