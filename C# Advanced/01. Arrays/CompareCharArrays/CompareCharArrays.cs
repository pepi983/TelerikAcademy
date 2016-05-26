using System;


namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();

            

            int N = Math.Min(array1.Length, array2.Length);

            for (int i = 0; i < N; i++)
            {
                if (array1[i] == array2[i] && i == N - 1)
                {
                    if (array1.Length < array2.Length)
                        Console.WriteLine("<");
                    else if (array1.Length > array2.Length)
                        Console.WriteLine(">");
                    else
                        Console.WriteLine("=");
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                else if (array1[i] < array2[i])
                {
                    Console.WriteLine("<");
                    break;
                }
            }

            
            
        }
    }
}
