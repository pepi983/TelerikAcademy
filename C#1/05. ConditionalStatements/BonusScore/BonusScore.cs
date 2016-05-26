using System;


namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());
            int bonusScore;

        if(score >= 1 && score <= 3)
            {
                bonusScore = score * 10;
                Console.WriteLine(bonusScore);
            }
        else if (score >= 4 && score <= 6)
            {
                bonusScore = score * 100;
                Console.WriteLine(bonusScore);
            }
        else if (score >= 7 && score <= 9)
            {
                bonusScore = score * 1000;
                Console.WriteLine(bonusScore);
            }
        else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
