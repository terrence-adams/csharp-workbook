using System;

namespace TextBasedAdventure
{
    class TextBasedAdventureGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }




        class TextBasedGame
        {

            bool armedWithStick = false;
            bool completedGame = false;
            bool aliveAtEndofGame = false;

            
            //initial game prompt
            public void gameStart()
            {

                Console.WriteLine("Welcome to the Cavern of Secrets!!!!!!!");
                randomWait();
                Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
                randomWait();

            }


            //arm with stick to fight spider
            public void pickUpStick()
            {
                Console.WriteLine("Type y / yes, or no/n");
                bool stickResponse = ConfirmYes();

                if(stickResponse)
                    {
                        randomWait();
                        Console.WriteLine("You have taken the Stick.");
                        randomWait();
                        armedWithStick = true;

                    }

                else
                {
                    randomWait();
                    Console.WriteLine("You did not take the stick. :(");
                    randomWait();

                }

            }

            public void approachSpider()
            {

                Console.WriteLine("As you proceed further into the cave, you see a small glowing object.");
                Console.WriteLine("Do you approach the object?: ");
                bool approachResponse = confirmYes();

                if (approachResponse)
                {
                    Console.WriteLine("You approach the object...");
                    randomWait();
                    Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                    randomWait();
                    Console.WriteLine("The eye belong to a giant spider!!!!!");
                    Console.WriteLine("Do you fight it? [Y/N]");



                }

            }



        
        static void randomWait()
        {
            Random rdm = new Random();
            int waitTime = rdm.Next(7);
            for( int x = 0; x < waitTime ; x++ )
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            }

       }

       static bool confirmYes()
       {
           bool confirmation = false; // return false if the answer isn't yes
           string [] yesArray = new string [] {"yes", "y"};
           string answer = "";
           answer = Convert.ToString(Console.ReadLine()).ToLower(); // converts t lowercase
           if(Array.Exists(yesArray, element => element == answer)) // if the response is in the expected resonse return true
           {

               confirmation = true;

           }

           return confirmation;
           
        }






        }
    }
}
