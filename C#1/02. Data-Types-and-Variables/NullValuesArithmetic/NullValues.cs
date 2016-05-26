using System;

    class NullValues
    {
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;
        Console.WriteLine("{0}\n{1}", intNull, doubleNull);

        intNull = intNull + 5;
        doubleNull = doubleNull + 3;
        Console.WriteLine("{0}\n{1}", intNull, doubleNull);

    }


    
    }

