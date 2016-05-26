using System;


namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            var hexNumber = Console.ReadLine();
            int n = hexNumber.ToString().Length - 1;
            double sum = 0;
            int br = n ;

            for(int i = 0; i <= n; i++)
            {
                if (hexNumber[i] == 'A')
                {
                    sum += (10 * Math.Pow(16, br));
                }

                else if (hexNumber[i] == 'B')
                {
                    sum += (11 * Math.Pow(16, br));
                }

                else if (hexNumber[i] == 'C')
                {
                    sum += (12 * Math.Pow(16, br));
                }

                else if (hexNumber[i] == 'D')
                {
                    sum += (13 * Math.Pow(16, br));
                }

                else if (hexNumber[i] == 'E')
                {
                    sum += (14 * Math.Pow(16, br));
                }

                else if (hexNumber[i] == 'F')
                {
                    sum += (15 * Math.Pow(16, br));
                }

                else
                {   int  wtf = (int)(hexNumber[i] - '0');
                    
                    sum += (wtf * Math.Pow(16, br));
                }
                br--;

            }
            Console.WriteLine(sum);
        }
    }
}
