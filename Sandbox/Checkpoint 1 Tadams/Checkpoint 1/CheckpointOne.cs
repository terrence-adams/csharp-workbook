using System;
using System.Collections.Generic;

namespace Checkpoint_1
{

    class CheckPointClassOne


    {
        Random rndm = new Random();

        public void divisbleBYThree()
        {
            Console.WriteLine("These numbers are divisble by 3.");
            for( int i = 1; i <= 100; i++)
            {
                
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);

                }

            }

        }

        public void sumOfAll()
        {
            int sum = 0;
            string exit = "ok";
            bool willContinue = true;
            string response = "";

            do
            {
                Console.WriteLine("Please enter a number to sum.");
               
                try
                {
                    sum = sum + int.Parse(Console.ReadLine());
                    Console.WriteLine("Your sum is : {0} ", sum);
                    Console.WriteLine("");
                    Console.WriteLine("Type \"ok\" to exit; or press Enter to continue.");
                    response = Console.ReadLine();
                    response = response.ToLower();

                    if(response == exit )
                    {
                        willContinue = false;
                        Console.WriteLine("Thank you for SUMMING with us.");
                        Console.WriteLine("Goodbye!!!");

                    }
                }

                catch(System.Exception e)
                {
                   Console.WriteLine(e);

                }
            }

            while(willContinue);

        }

        private int randomGenerator()
        {
            return rndm.Next(1,11);
        }

        private void promptForGuesses()
        {
            Console.WriteLine("Please enter your number for your guess.");

        }

        private int getGuess()
        {
            int myGuess = 0;
            try
            {
                myGuess = Int32.Parse(Console.ReadLine());
                return myGuess;

            }

            catch
            {
                return -1;

            }

        }

        private void promptResult(string s)
        {
            Console.WriteLine("You {0}!", s);

        }

        public void guessingGame()
        {
            int winningNumber = 0;
            int userGuessedNumber = 0;
            winningNumber = randomGenerator();
            int count = 1;
            Console.WriteLine("Welcome to the Guessing Game!");

            while(count < 5)
            {
                promptForGuesses();
                userGuessedNumber = getGuess();
                if(userGuessedNumber == winningNumber && count <5)
                    {
                        promptResult("Won");
                        Console.WriteLine("The number was {0}", winningNumber);
                        break;
                    }

                

                else if(userGuessedNumber!= winningNumber && count == 4)
                {
                    promptResult("Lost");
                    Console.WriteLine("The number was {0}", winningNumber);

                }

                count++;
            }

            

        }


        private string [] stripString(string s)
        {
            string [] cleanString;
            cleanString = s.Split(",");
            return cleanString;



            
            
            

        }

        private int [] returnIntArray(string [] s)
        {
            int [] numericArray ;
            List <int> myList = new List<int> ();

            for(int i = 0 ; i < s.Length; i++)
                {

                    myList.Add(Int16.Parse(s[i]));

                }

                numericArray= myList.ToArray();
                return numericArray;

        }

        private int findHighest(int [] x)
        {
            int highest = x[0];

            for(int i = 1; i < x.Length; i++)
            {
                if(x[i] > highest)
                {
                    highest = x[i];
                }

            }
            
            return highest;

        }

        public void findTheHighestNumber()
        {

            Console.WriteLine("Please enter a series of numbers, separated by a ',' :");
            string myString = Console.ReadLine();
            string [] myStringArray= stripString(myString);
            int [] myIntArray = returnIntArray(myStringArray);
            int myHighest = findHighest(myIntArray);
            Console.WriteLine("The highest number is {0}", myHighest);

        }


        public void getFactorialFactory()
        {
            long myFactorial = 0;
            int yourNumber = 0;
            Console.WriteLine("Please enter your number to find the factorial of it:");
            try
            {
                yourNumber = Int32.Parse(Console.ReadLine());
                myFactorial = getFactorial(yourNumber);
                Console.WriteLine("Your factorial is {0}! = {1}", yourNumber,myFactorial);



            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }


        }

        private long getFactorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            else
            {
            return n * getFactorial(n-1);
            }
        }
    }







}