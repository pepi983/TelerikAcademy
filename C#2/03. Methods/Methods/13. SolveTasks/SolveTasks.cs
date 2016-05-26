using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolveTasks
{
    class SolveTasks
    {
        static void Main(string[] args)
        {
            enterChoice:
            Console.WriteLine("For reverses the digits of a number - ENTER 1");
            Console.WriteLine("For calculates the average of a sequence of integers - ENTER 2");
            Console.WriteLine("Solves a linear equation a * x + b = 0 - ENTER 3");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                insertNumber:
                Console.WriteLine("Enter a number:");
                double number = double.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    ReverseDigits(number);
                }
                else
                {
                    Console.WriteLine("The decimal number should be non-negative");
                    goto insertNumber;
                }
            }
            else if (choice == 2)
            {
                insertSequence:
                Console.WriteLine("Enter a sequence:");
                string chek = Console.ReadLine();

                if (chek != string.Empty)
                {
                    int[] sequence = chek.Split(' ').Select(s => int.Parse(s)).ToArray();
                    TheAverage(sequence);
                }
                else
                {
                    Console.WriteLine("The sequence should not be empty");
                    goto insertSequence;
                }
            }
            else if (choice == 3)
            {
            insertA:
                Console.Write("Enter A:");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Enter B:");
                int B = int.Parse(Console.ReadLine());

                if (A != 0)
                {
                    DecisionOfEquation(A, B);
                }
                else
                {
                    Console.WriteLine("A should not be equal to 0");
                    goto insertA;
                }
            }
            else
            {
                Console.WriteLine("Wrong Choice");
                goto enterChoice;
            }

            Console.WriteLine("If you want to continue ENTER 1");

            int refresh = int.Parse(Console.ReadLine());

            if(refresh == 1)
            {
                goto enterChoice;
            }
            else
            {
                Console.WriteLine("Goodbye");
            }

        }
        static void ReverseDigits(double number)
        {
            char[] digits = Convert.ToString(number).ToCharArray();

            Array.Reverse(digits);

            string reverse = string.Empty;

            for (int i = 0; i < digits.Length; i++)
            {
                reverse += digits[i];
            }

            double reverseNumber = Convert.ToDouble(reverse);

            Console.WriteLine(reverseNumber);
        }

        static void TheAverage(int[] numbers)
        {
            double average;
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            average = (double)sum / numbers.Length;

            Console.WriteLine("{0:F2}", average);
        }

        static void DecisionOfEquation(int A, int B)
        {
            double result = (-B) / (double)A;

            Console.WriteLine(result);
        }

    }
}
