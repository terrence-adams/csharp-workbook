using System;

namespace inheritance
{

    public class Stringtransform
    {

        public void TransformStringArray (string s)
        {
            Char[] reversedStringArray = s.ToCharArray();
            Array.Reverse(reversedStringArray);
            s = new string (reversedStringArray);
            Console.WriteLine(s);




        }


        virtual public string Transform(string s)
        {
            string result = "";

            if( s == null || s == "")
            {

                throw new ArgumentNullException(nameof(s));


            }


            for( int i = s.Length - 1; i >= 0 ; i--)
            {

                result += s[i];


            }

            return result;

                


        }

    }



    public class TransformUpper : Stringtransform
    {
        override public string Transform(string s)
        {
            if(s == null)
            {

                throw new ArgumentException("s");

            }

            string result = s.ToUpper(); 

            return result;

        }
    }

    public class TransformLower :TransformUpper

    {
        override  public string Transform(string s)
        {
            string result = s.ToLower();

            return result;


        }


    }



    

}