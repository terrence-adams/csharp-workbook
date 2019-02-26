using System;

namespace AllUniqueWB
{

    public class SpecialCharacterChecker
    {
        public string specialChars = "~!@#$%^&*(){}|:\"<>?[]\\',./'";


        public bool containsSpecialChar(string myWord)
        {
            bool containsSpecial = false;
            myWord.ToLower();


            foreach(char c in myWord)
            {
                containsSpecial= specialChars.Contains(c);
                if(containsSpecial)
                {
                    Console.WriteLine("Contains special character: {0}", c);
                    break;
                }

            }

            return containsSpecial;



        }




    }


 }

   