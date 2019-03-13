using Microsoft.EntityFrameworkCore;
using System;


namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Application myApp = new Application();
            bool finished = false;
            string input;
            while (!finished)
            {
                myApp.buildApp();
                Console.WriteLine("Would you like to restart? y/n");
                input = Console.ReadLine();
                if (input.ToLower() == "n")
                {
                    finished = true;
                }

            }



        }
    }
}
