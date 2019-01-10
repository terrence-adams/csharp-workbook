using System;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int stick = 0;
            randomWait();
            Console.WriteLine("Welcome to the Cavern of Secrets!!!!!!!");
            randomWait();
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            randomWait();
            Console.WriteLine("Type y / yes, or no/n");
            string pickUpStick = Convert.ToString(Console.ReadLine());
            pickUpStick = pickUpStick.ToLower();

            if(string.Equals(pickUpStick,"y") || string.Equals(pickUpStick,"yes"))
            {
                randomWait();
                Console.WriteLine("You have taken the Stick.");
                randomWait();
                stick = 1;

            }

            else
            {
                randomWait();
                Console.WriteLine("You did not take the stick. :(");
                randomWait();

            }

            Console.WriteLine("As you proceed further into the cave, you see a small glowing object.");
            Console.WriteLine("Do you approach the object?: ");


            if(confirmYes())
            {
                Console.WriteLine("You approach the object...");
                randomWait();
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                randomWait();
                Console.WriteLine("The eye belong to a giant spider!!!!!");
                Console.WriteLine("Do you fight it? [Y/N]");

                if(confirmYes())
                {

                    if(stick==1)
                    {
                        Console.WriteLine("");

                    }

                }


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
