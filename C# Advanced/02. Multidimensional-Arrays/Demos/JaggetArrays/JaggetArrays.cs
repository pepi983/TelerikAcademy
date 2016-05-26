using System;

public class JaggedArrays
{
    static void Main()
    {

        int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
        int[] sizes = new int[3];
        int[] offsets = new int[3];

        // Calculate the sizes for each reminder (0, 1 and 2)
        foreach (var number in numbers)
        {
            int remainder = number % 3;
            sizes[remainder]++;
        }

        // Calculate the list of numbers for each reminder (0, 1 and 2)
        int[][] numbersByRemainder = new int[3][]
                                    {
                                        new int[sizes[0]],
                                        new int[sizes[1]],
                                        new int[sizes[2]]
                                    };

        foreach (var number in numbers)
        {
            int remainder = number % 3;
            int index = offsets[remainder];
            offsets[remainder]++;
            numbersByRemainder[remainder][index] = number;
        }

        // Print the result jagged array
        for (int row = 0; row < numbersByRemainder.GetLength(0); row++)
        {
            foreach (var num in numbersByRemainder[row])
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

//int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };

//// The new code
//// Size of the nullable int array: 3 x ((size of the list) + 1
//int?[,] numbersByRemainder2 = new int?[3, (numbers.Length + 1)];
//numbersByRemainder2[0, 0] = 0;
//        numbersByRemainder2[1, 0] = 0;
//        numbersByRemainder2[2, 0] = 0;
//        int remainder2 = 0;

//        // only one divide/check per number... only one checking and placing loop
//        foreach (int number in numbers)
//        {

//            remainder2 = number % 3;

//            numbersByRemainder2[remainder2, 0]++;
//            numbersByRemainder2[remainder2, (int)numbersByRemainder2[remainder2, 0]] = number;
//        }

//        // Show the result - Variant 1... use the NULL as missing elements:
//        Console.WriteLine("\nVariant 1:");
//        for (int row = 0; row< 3; row++)
//        {
//            for (int col = 1; col <= (numbers.Length); col++)
//            {
//                Console.Write("{0} ", numbersByRemainder2[row, col]);
//            }
//            Console.WriteLine();
//        }

//        // Show the result - Variant 2... use the calculated number of reminders:
//        Console.WriteLine("\nVariant 2:");
//        for (int row = 0; row< 3; row++)
//        {
//            for (int col = 1; col <= numbersByRemainder2[row, 0]; col++)
//            {
//                Console.Write("{0} ", numbersByRemainder2[row, col]);
//            }
//            Console.WriteLine();
//        }
