using System;


namespace MMSAofNumbers
{
    class MMSAofNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double min = 10000;
            double max = -10000;
            double sum = 0;
            double avg = 0;

            for(int i = 1; i <= N; i++)
            {
                double P = double.Parse(Console.ReadLine());
                min = Math.Min(min, P);
                max = Math.Max(max, P);
                sum += P;
            }
            avg = sum / N;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
            
        }
    }
}
