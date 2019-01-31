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
        private const string vay = "yay";

        private string getWord()
        {
            string w = "";
            w = Console.ReadLine().ToLower();
            return w;
        }

        private string [] getSentence()
        {
            string [] oldSentence ;
            string w = Console.ReadLine().ToLower();

            if(verifySpacing(w))
            {
                oldSentence = w.Split(' ');

            }

            else
            {
                oldSentence = "That was a word, not a sentence.".Split();

            }

            return oldSentence;



        }

        private bool verifySpacing(string w)
        {
            bool hasSpace = false;

            if(w.IndexOfAny(new char [] {' '} ) > 0)
            {
                hasSpace = true;

            }

            return hasSpace;


        }

        private int findIndexFirstVowel(string incomingWord)
        {
            int index = 0;
            index = incomingWord.IndexOfAny(new char [] {'a','e','i','o','u','y'});
            return index;
        }

        private bool findPunctuation(string [] incomingWord)
        {
            bool isPunctuated = false;
            int index = 99;
            
            index = Array.IndexOf(incomingWord, new char [] {'!','.','?',';'});
            if(index >= 0)
            {
                isPunctuated = true;
            }

            return isPunctuated;


        }

        private string findIndexFirstChar(string myWord)
        {   
            string firstChar =   myWord.Substring(0,1);
            return firstChar;
        }


/*Creation of Pig Latin Words and Sentences */
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




       /* private string makeVowelPigLatinWord(string word2)
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


        }*/

        private string [] makePigLatinSentence(string [] s)
        {
            string [] newPGLS = new string [s.Length] ;

            if(findPunctuation(s))
            {

                string punctEnd = s[s.Length-1];

                    for(int i = 0; i < s.Length -1; i++)
                    {
                        if( findIndexFirstVowel(s[i]) == 0)
                            newPGLS[i] = vowelFirstyay(s[i]);
                        
                        else
                        {
                            newPGLS[i] = makePigLatinWord(s[i]);
                        }

                    }
                newPGLS[newPGLS.Length] = punctEnd;

            }



            for(int i = 0; i < s.Length; i++)
            {
                if( findIndexFirstVowel(s[i]) == 0)
                    newPGLS[i] = vowelFirstyay(s[i]);
                
                else
                {
                    newPGLS[i] = makePigLatinWord(s[i]);
                }

            }

            //newPGLS[newPGLS.Length -1] = s[s.Length -1];

            return newPGLS;

        }

        private string vowelFirstyay(string vowelYAY)
        {

            return vowelYAY + vay;

        }




/*The execution of the game. */

        public void executePigLatin()
        {
            string newWord = "";
            string myPGWrd = "";
            string newPGStnce = "";
            Console.WriteLine("What is your word?:");
            newWord = getWord();
            
            if(findIndexFirstVowel(newWord)== 0)
            {
                myPGWrd = vowelFirstyay(newWord);
            }
            else
            {
                myPGWrd = makePigLatinWord(newWord);
            }
            Console.WriteLine("Your new word is: {0}", myPGWrd);

            Console.WriteLine("What is your sentence?");

            newPGStnce = String.Join(" ",makePigLatinSentence(getSentence()));

            Console.WriteLine("Your new setence is: {0}", newPGStnce);


        }

    }

}
