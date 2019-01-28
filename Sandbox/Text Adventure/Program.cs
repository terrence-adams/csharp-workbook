using System;

namespace TextAdventure
{
    class TextBasedAdventureGame
    {
        static void Main(string[] args)
        {
            GameExecution myGame = new GameExecution();
            myGame.executeTextBasedGame();
        }



    }
    class TextBasedGame
{

        bool armedWithStick = false;
        public bool completedGame = false;
        public bool aliveAtEndofGame = false;
    

        int min = 0;
        int max = 0;

        
        //initial game prompt
        public void gameStart()
        {

            Console.WriteLine("Welcome to the Cavern of Secrets!!!!!!!");
            randomWait();
            Console.WriteLine("You enter a dark cavern out of curiosity. \nIt is dark and you can only make out a small stick on the floor.");
            

        }

        /* Game Actions **************************/
        //arm with stick to fight spider
        public void pickUpStick()
        {
            Console.WriteLine("Do you pick it up?");
            Console.WriteLine("[y/n]");
            bool stickResponse = confirmYes();

            if(stickResponse)
                {
                    randomWait();
                    Console.WriteLine("You have taken the Stick.");
                    randomWait();
                    armedWithStick = true; // sets range on random from 3 to 11
                    armWithStickRange(armedWithStick);

                }

            else
            {
                randomWait();
                Console.WriteLine("You did not take the stick. :(");
                armWithStickRange(armedWithStick); //sets value for min max on random range
                randomWait();

            }

        }

        public void approachSpider()
        {
            bool approachResponse = false;

            Console.WriteLine("As you proceed further into the cave, you see a small glowing object.");
            Console.WriteLine("Do you approach the object?: ");
            approachResponse = confirmYes();

            if (approachResponse) // if you approach call spider fight method
            {
                bool fightSpiderResponse = false;
                Console.WriteLine("You approach the object...");
                randomWait();
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                randomWait();
                Console.WriteLine("The eye belong to a giant spider!!!!!");
                randomWait();
                Console.WriteLine("Do you fight it? [Y/N]");
                fightSpiderResponse = confirmYes();

                if(fightSpiderResponse)
                {
                    fightSpiderAttack();

                }

                else
                {
                    spiderAmbush();

                }

            }

            else // if you do not approach, call the fail to leave method
            {
                failToLeave();
                

            }


        }

        private void fightSpiderAttack()
        {


            if(armedWithStick)
            {
                msgFightWithStick();
                randomWait();
                spiderFightRandom();
            }

            else
            {
                msgFightNoStick();
                randomWait();
                spiderFightRandom();
            }


        }






        /*Supporting methods for main methods of the game.*/
        private void failToLeave()
        {
            Console.WriteLine("You turn away from the glowing object, and attempt to leave the cave.");
            randomWait();
            Console.WriteLine("But something won't let you leave...");
            Console.WriteLine("The Spider has you, you are its dinner.Goodbye!");
            randomWait();
            Environment.Exit(0);
            
            

        }

        private void spiderAmbush()
        {
            Console.WriteLine("You choose not to fight the spider.");
            randomWait();
            Console.WriteLine("As you turn away, it ambushes you and impales you with its fangs.");
            Console.WriteLine("Thank you for playing.");
            Environment.Exit(0);
        }

        


        // determines the range for the random for the attack based on stick/no stick
        private void armWithStickRange(bool armed)
        {
            if(armed)
            {
                min = 3;
                max = 11; //desired range is 3 to 10

            }

            else
            {
                min = 1;
                max = 9;

            }

        }

        // Spider fight, based on mix/max set by armed stick for the range on random
        private void spiderFightRandom()
        {
            Random rndm = new Random();
            int myAttack = rndm.Next(min, max);
            int spiderAttack = rndm.Next(1, 6);
            Console.WriteLine("You hit a {0}", myAttack);
            Console.WriteLine("The spider hits a {0}", spiderAttack);
            randomWait();

            if(spiderAttack < myAttack)
            {
                Console.WriteLine("You killed the spider!");
                completedGame = true;
                

            }

            else{
                if(spiderAttack < 5)
                {
                    Console.WriteLine("You didn't do enough damage to kill the spider, but you managed to escape!!!");
                    completedGame = true;
                }
                else
                {
                    Console.WriteLine("The spider has dealt more damage than you!");
                    completedGame = false;
                }
            }

        }




        // Methods for displaying messages during game play.
        private void msgFightWithStick()
        {
            Console.WriteLine("You only have a stick to fight with.");
            Console.WriteLine("You quickly jab the spider in its eye and gain an advantage.");
            randomWait();
            Console.WriteLine("Fighting!!!!!...");
            Console.WriteLine("You must hit above a 5 to kill the Spider!");
            Console.WriteLine("If the spider hits higher than you, you will die! :(");
            randomWait();


        }

        private void msgFightNoStick()
        {
            Console.WriteLine("You don't have anything to fight with !!! :(");
            randomWait();
            Console.WriteLine("Fighting!!!!!...");
            Console.WriteLine("You must hit above a 5 to kill the Spider!");
            Console.WriteLine("If the spider hits higher than you, you will die! :(");
            randomWait();
        }

        //random wait generator for text based game
        private void randomWait()
        {
            Random rdm = new Random();
            int waitTime = rdm.Next(5);
            for( int x = 0; x < waitTime ; x++ )
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            }

    }

    //confirms response is a yes within expected response array
    public  bool confirmYes()
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
    

    class GameExecution
    {
       TextBasedGame game= new TextBasedGame();
       bool completed = false;
       bool survivedAlive = false;

       bool replayGame = false;

       private bool runGame()
       {

           game.gameStart();
           game.pickUpStick();
           game.approachSpider();
           completed = game.completedGame;
           survivedAlive = completed;
           return(msgGameEnd(survivedAlive));

       }

       private bool msgGameEnd(bool alive)
       {
           if(alive)
           {
                Console.WriteLine("You managed to escape the cavern alive! Would you like to play again? [y/n]");
                replayGame =  game.confirmYes();
                return replayGame;
           }
            else
            {
                Console.WriteLine("You have died! Would you like to play again? [y/n]:");
                replayGame = game.confirmYes();
                return replayGame;

            }

       }

        public void executeTextBasedGame()
        {
            do
            {
                runGame();
            }

            while(replayGame);

        }


    }
}
