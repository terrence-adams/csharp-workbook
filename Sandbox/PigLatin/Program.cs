using System;

namespace PigLatin
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            PigLatinGame pg = new PigLatinGame();
            pg.executePigLatin();
        }
    }
    public class PigLatinGame
    {

        private const string ay = "ay";

        private string getWord()
        {
            string w = "";
            w = Console.ReadLine().ToLower();
            return w;
        }

        private int findIndexFirstVowel(string incomingWord)
        {
            int index = 0;
            index = incomingWord.IndexOfAny(new char [] {'a','e','i','o','u','y'});
            return index;
        }

        private string findIndexFirstChar(string myWord)
        {   
            string firstChar =   myWord.Substring(0,1);
            return firstChar;
        }

        private string makePigLatinWord(string word1)
        {
            string fChar = "";
            string myPigword = "";
            string restMyWord = "";
            fChar = findIndexFirstChar(word1);
            restMyWord = word1.Substring(1);
            myPigword = restMyWord + fChar + ay;
            return myPigword;
            
        }


        private string makeComplexPigLatinWord(string word2)
        {
            int frstVwlIndex = 0;
            string myPigword = "";
            string restMyWord = "";
            string fWord = "";

            frstVwlIndex = findIndexFirstVowel(word2);
            fWord = word2.Substring(0, frstVwlIndex -1);
            restMyWord = word2.Substring(frstVwlIndex);
            myPigword =  restMyWord + fWord + ay;

            return myPigword;






        }


        public void executePigLatin()
        {
            string newWord = "";
            string myPGWrd = "";
            Console.WriteLine("What is your word?:");
            newWord = getWord();
            myPGWrd = makePigLatinWord(newWord);
            Console.WriteLine("Your new word is: {0}", myPGWrd);

        }

    }

}
