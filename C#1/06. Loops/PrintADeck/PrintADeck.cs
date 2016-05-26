using System;


    class PrintADeck
    {
    static void Main()
    {
        string card = Console.ReadLine();

        if(card == "J" || card == "Q" || card == "K" || card == "A")
        {
            for(int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", i);
                
            }
            Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds ");
            if (card == "Q")
            {
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds ");
            }
            if(card == "K")
            {
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds ");
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds ");
            }
            if(card == "A")
            {
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds ");
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds ");
                Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds ");
            }
        }
        else
        {
            int a = Convert.ToInt32(card);
            for(int i = 2; i <= a ; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds ", i);
            }
                

            
        }
        }
    }

