using System;
using System.Collections;
using System.IO;
using System.Text;

namespace wordguess

{
    public class WordGuessGame
    {
        public string randomWrd = "";
        public string  userGuess = "";
        string [] wordArray ;
        bool guessedCorrectly = false;
        

        // reads static file into the array
        public void readFileIntoArray()
        {
            //var fs = new FileStream (@"./words_alpha.txt", FileMode.Open, FileAccess.Read);
            wordArray = File.ReadAllLines(@"./words_alpha.txt", Encoding.UTF8);

        }

        // method used to validate the file is loaded
        public void printFileToScreen()
        {
            foreach(string s in wordArray)
            {
                Console.WriteLine(s);
            }
        }


        // randomly selects int 0 to array length, and assigns that as random word
        public string findRandomWord()
        {
            Random rndm = new Random ();
            string chosenWrd = "";
            int index = 0;
            index = rndm.Next(0, wordArray.Length);
            chosenWrd = wordArray[index];            
            return chosenWrd;
        }

        // gets the user's guess and returns it for comparisson 
        private string getUserGuess()
        {
            Console.WriteLine("Please enter a word for your guess:");
            string userGuess = Console.ReadLine()?.ToLower();
            return userGuess;
        }


        public int compareStrings(string r)
        {
            int order = 0;
            string random = r;
            //Console.WriteLine(random);  used for testing
            string guess = getUserGuess();
            order = String.Compare(guess, random);
            return order;
        }

        //displays results of comparisson
        public void displayResults(int x)
        {
            if(x > 0)
            {
                Console.WriteLine("Your guess is after the chosen word.");
            }

            else if (x < 0)
            {
                Console.WriteLine("Your guess is before the chosen word.");
            }

            else
            {
                Console.WriteLine("You guessed correctly.");
                guessedCorrectly = true;
            }

        }

        // main game execution loop
        public void playGame()
        {
            int count = 0;
            readFileIntoArray();
            string rndm = findRandomWord();
            int maximumNumber = 10;
            Console.WriteLine("Welcome, you have 10 guesses to guess the chosen word.");
            while(!guessedCorrectly && count < maximumNumber)
            {
                displayResults(compareStrings(rndm));
                Console.WriteLine("Number of guesses : {0}", count +1);
                count++;
            }
            if(count >= maximumNumber)
            {
                Console.WriteLine("Sorry, you are out of guesses.");
            }

        }




    }






}