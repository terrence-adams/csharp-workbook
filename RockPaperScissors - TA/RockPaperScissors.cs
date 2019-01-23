using System;

namespace RockPaperScissors
{
    class Program
    {
        public static int playerOneWins = 0;
        public static int playerTwoWins = 0;
        public static void Main()
        {
            //Program prg = new Program();
            string hand2 = "";
            bool repeat = false;
            string yes = "yes";
            string answer = "";
         


            
            do
            {

            //executes game, but allows the user to contine playing.
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            hand2 = handTwoRandom();
            Console.WriteLine(CompareHands(hand1, hand2));
            Console.WriteLine("Do you want to continue ?: [y/n]");
            answer = Console.ReadLine().ToLower();

            if(answer == yes || answer == "y")
            {
                repeat = true;

            }

            else
            {
                repeat = false;

            }


            }
            
            while(repeat);

            // leave this command at the end so your program does not close automatically
            Console.WriteLine("Press Enter to see the scores!.");
            Console.ReadLine();
            Console.WriteLine("Player one's score is {0}", playerOneWins);
            Console.WriteLine("Player two's score is {0}", playerTwoWins);
            Console.ReadKey();
            
        }
        
        public static string CompareHands(string hand1, string hand2)
        {

            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";
            Program prg = new Program();



            if(hand1 == hand2)
            {
                return "It's a Tie!!";

            }

            else if (hand1 == rock)
            {
                if(hand2 == scissors)
                {
                
                    ++playerOneWins;
                    return "Hand one wins!";

                }

                else
                {
                    ++playerTwoWins;
                    return "Hand two wins";

                }
            }

            else if(hand1 == paper)
            {

                if(hand2 == rock)
                {
                    ++playerOneWins;
                    return "Hand one wins!!!";

                }

                else
                {
                    ++playerTwoWins;
                    return "Hand two wins!!!";

                }

            }

            else
            {

                if(hand2 == rock)
                {
                    ++playerTwoWins;
                    return "Hand two wins!!!";

                }

                else

                {
                    ++playerOneWins;
                    return "Hand one wins!!";
                }

            }




            }

            private static string handTwoRandom()
            {
                string myHand = "";
                int index = 0;
                string [] arrayRPS = new string [] {"rock", "paper", "RockPaperScissors"};
                Random myRandomizer = new Random();
                index = myRandomizer.Next(0,3);
                myHand = arrayRPS[index];
                return myHand;



            }
           // return hand1 + ' ' + hand2;
        }
    }

