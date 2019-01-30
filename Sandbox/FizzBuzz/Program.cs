using System;

namespace FizzBuzz
{
    class Program
    {
        static int number = 1;
        static string fizz = "fizz";
        static string buzz = "buzz";

       static public int max = 0;

        static void Main(string[] args)
        {
            fizzBuzzGenerator();
        }

        
        public static bool divisibleByThree(int x)
        {
            bool divisible = false;
            if(x % 3 == 0)
            {
                divisible = true;


            }

            return divisible;

        }

        public static bool divisibleByFive(int x)
        {
               bool divisible = false;
            if(x % 5 == 0)
            {
                divisible = true;


            }

            return divisible;

        }

        private static void printToScreen( string s)
        {

            Console.WriteLine(s);

        }


         private static void printToScreen( int s)
        {

            Console.WriteLine(s.ToString());

        }


         private static void printToScreen( string one, string two)
        {

            Console.WriteLine(one + " " + two);

        }


        public static void setMaxValue( int MAX)
        {

            max = MAX;

        }

        public static void getMaxValue()
        {
            Console.WriteLine("What is the value you want to FIZZBUZZ for?");
           setMaxValue(Int32.Parse(Console.ReadLine()));

        }

        public static void fizzBuzzGenerator()
        {


            getMaxValue();

            for( int i = number ; i <= max; i++)
            {

                if(divisibleByFive(i) && divisibleByThree(i))
                {

                    printToScreen(fizz, buzz);

                }

                else if ( divisibleByFive(i))
                {
                    printToScreen(buzz);

                }

                else if ( divisibleByThree(i))
                {

                    printToScreen(fizz);
                }

                else
                {
                    printToScreen(i);
                }


            }


        }


    }
}
