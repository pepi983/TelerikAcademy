using System;
using System.Collections.Generic;


namespace SubsetWithSumS
{

    class SubsetWithSumS
    {
        public static int[] Combination(int[] arr)
        {
          

            if (arr.Length == 1)
                return arr ;

            // чете последният елемент 
            int c = arr[arr.Length - 1];

            // Махаме последният елемент от масива
            Array.Resize(ref arr, arr.Length - 1);
            int[] returnArray = Combination(arr);

            // Лист който пази всички суми
            List<int> finalArray = new List<int>();

            // add whatever is coming from the previous routine
            foreach (int s in returnArray)
                finalArray.Add(s);

            // take the last character
            finalArray.Add(c);

            // take the combination between the last char and the returning strings from the previous routine
            foreach (int s in returnArray)
                finalArray.Add(s + c);

            return finalArray.ToArray();
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int S = int.Parse(Console.ReadLine());
            int chek = 0;

            int[] newArray = Combination(array);

            foreach (int item in newArray)
            {
                if (item == S)
                {
                    Console.WriteLine("yes");
                    chek = 1;
                    break;
                }
            }

            if(chek == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
