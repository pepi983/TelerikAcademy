using System;


class Years
{
    static void Main()
    {

        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int myAge = today.Year - birthday.Year;
        
        if (today.Month <= birthday.Month)
        {
            if (today.Month == birthday.Month)
            {
                if (today.Day < birthday.Day)
                {
                    myAge--;
                }

            }
            else
                myAge--;
        }
        Console.WriteLine(myAge);
        Console.WriteLine(myAge + 10);
    }
}