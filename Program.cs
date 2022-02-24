using System;

namespace pokerchiplab
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice = "";
            Console.WriteLine("Welcome to the main menu! Use the following integers to pick an action: \n1 = Display Preston's Poker Chips when he lays them all out \n2 = Display Preston's Poker Chips after he angrily loses a game \n3 = Exit");
            menuChoice = Console.ReadLine(); //prime read
            Route(menuChoice);
        }

        static void Route(string menuChoice)
        {
            while(menuChoice != "3")
            {
                if(menuChoice != "1" && menuChoice != "2")
                {
                    Console.WriteLine("Not a valid selection");
                }
                if(menuChoice == "1")
                {
                    System.Console.WriteLine(" ");
                    for(int i = 0; i < 3; i++)
                    {
                        for(int j = 0; j < 4 ; j++)
                        {
                            Console.Write("0 ");
                        }
                        Console.WriteLine("");
                    }
                    System.Console.WriteLine("  ");
                }
                if(menuChoice == "2")
                {
                    Random randomNumber = new Random();
                    int number = randomNumber.Next(1);
                    System.Console.WriteLine(" ");
                    for(int i = 0; i < 3; i++)
                    {
                        for(int j = 0; j < 4 ; j++)
                        {
                            number = randomNumber.Next(2);
                            if(number ==1)
                            {
                            Console.Write("0 ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.Write("\n");
                    }  
                    System.Console.WriteLine(" ");
                }
                Console.WriteLine("Welcome to the main menu! Use the following integers to pick an action: \n1 = Display Preston's Poker Chips when he lays them all out \n2 = Display Preston's Poker Chips after he angrily loses a game \n3 = Exit");
                menuChoice = Console.ReadLine(); //prime read
            }
        }
    }
}
