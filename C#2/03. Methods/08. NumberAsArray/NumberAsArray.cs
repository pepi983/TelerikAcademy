using System;

 
namespace _08.Number_as_array
{
    class Program
    {

        static int[] Sum(int[] first, int[] second)
        {
            int[] numbers = new int[first.Length];

            for (int i = 0; i < first.Length; i++)
            {
                
                numbers[i] += first[i] + second[i];
                
                if (numbers[i] > 9)
                {
                    numbers[i] %= 10;

                    //if it is the last digits
                    if (i == first.Length - 1)
                    {
                        //create new array with lenght +1
                        int[] newNumbers = new int[first.Length + 1];
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            newNumbers[j] = numbers[j];
                        }
                        newNumbers[numbers.Length] = 1;
                        return newNumbers;
                    }

                    //add one to the next element
                    numbers[i + 1] = 1;
                }

            }
            return numbers;
        }

        static void Main(string[] args)
        {

            string empty = Console.ReadLine(); 
            string first = Console.ReadLine().Replace(" ", string.Empty); 
            string second = Console.ReadLine().Replace(" ", string.Empty); 
            int[] firstArray = new int[Math.Max(first.Length, second.Length)];
            int[] secondArray = new int[Math.Max(first.Length, second.Length)];
            
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (i < first.Length)
                {
                    firstArray[i] = first[i] - '0';
                }
                if (i < second.Length)
                {
                    secondArray[i] = second[i] - '0';
                }
            }


            int[] numbers = Sum(firstArray, secondArray);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.Write("{0}", numbers[i]);
                }
                else
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }
        }
    }
}