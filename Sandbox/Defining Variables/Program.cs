using System;

namespace Defining_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            declareVar();
        }


        static void declareVar()
        {

            bool people = true;
            bool r = false;
            decimal num = 25.2523455m;
            string firstName = "Terrence";
            string lastName = "Tester";
            int age = 25;
            string job = "SDET";
            string favoriteBand = "Alabama Shakes";
            string favoriteSprotsTeam = "Dallas Cowboys";

            int hundred = 100;
            int ten = 10;
            Console.WriteLine("I am {0}, my name is {1}, and my favorite band is {2}", age, firstName, favoriteBand);
            Console.WriteLine(hundred * ten);
            Console.WriteLine(hundred + 10);
            Console.WriteLine( hundred / ten);
            Console.WriteLine(hundred - ten);
            Console.WriteLine(Convert.ToInt16(num));


        }
    }
}
