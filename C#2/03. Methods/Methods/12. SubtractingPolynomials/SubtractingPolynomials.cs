using System;
using System.Linq;

namespace _12.SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        static void SubtractionOfPolinoms(int[] array1, int[] array2)
        {
            int[] substractPolinoms = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                substractPolinoms[i] = array1[i] - array2[i];

                if (i == array1.Length - 1)
                {
                    Console.Write("{0}", substractPolinoms[i]);
                }
                else
                {
                    Console.Write("{0} ", substractPolinoms[i]);
                }
            }
       
        }

        static void MultiplicationPolinoms(int[] array1, int[] array2)
        {
            int[] polinomsMultiplication = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                polinomsMultiplication[i] = array1[i] * array2[i];

                if (i == array1.Length - 1)
                {
                    Console.Write("{0}", polinomsMultiplication[i]);
                }
                else
                {
                    Console.Write("{0} ", polinomsMultiplication[i]);
                }
            }

        }

        static void Main()
        {
            Console.WriteLine("Enter Polinoms:");
            int[] firstPolynomials = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] secondPolynomials = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            Console.WriteLine("Enter 1 for subtracting or 2 for Multiplication:");

            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                SubtractionOfPolinoms(firstPolynomials, secondPolynomials);
            }
            else if(choice == 2)
            {
                MultiplicationPolinoms(firstPolynomials, secondPolynomials);
            }
            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
    }
}
