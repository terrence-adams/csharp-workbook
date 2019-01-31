using System;
using HelloWorld

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;
            int year = 0;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What year were you born?");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello again {0}. So you are {1} years old, and you were born in the year {2}.", name, age, year);
            Console.WriteLine("Thank you.")

        }
    }
}
