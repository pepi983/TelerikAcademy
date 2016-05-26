using System;
using System.Linq;

namespace _09.SortingArray
{
    class SortingArray
    {
        static int GetMaxNumber(int[] array)
        {
            int maxNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }

            return maxNumber;
        }

        static int[] SortArray(int[] array, int lenght)
        {
            int[] sortedArray = new int[lenght];
           int position = sortedArray.Length - 1;

            for (int j = 0; j < array.Length; j++)
            {
                int maxNumber = GetMaxNumber(array);

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == maxNumber)
                    {
                        sortedArray[position] = maxNumber;
                        array[i] = int.MinValue;
                        position--;
                        break;
                    }
                }
            }

            return sortedArray;
        }
        static void Main()
        {
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            array = SortArray(array, arrayLenght);

            for (int i = 0; i < arrayLenght; i++)
            {
                if(i == arrayLenght)
                {
                    Console.Write("{0}", array[i]);
                }
                else
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }
    }
}
