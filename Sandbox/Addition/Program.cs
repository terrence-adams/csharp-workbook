using System;

namespace Addition
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            getNumbers();

            
        }

        private static void getNumbers()
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("Please enter a number to sum.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number to sum.");
            y = Convert.ToInt32(Console.ReadLine());
            int sum = x + y;
            
            Console.WriteLine("Your sum is:{0}", sum);

        }

    }
}
