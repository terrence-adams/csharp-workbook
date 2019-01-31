using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion1();
        }


        public static void Conversion1()
        {
            int inches = 0;
            int yards ;
            int inchesInYard = 36;
            
            Console.WriteLine("How many yards do you want to convert to inches?");
            yards = Convert.ToInt32(Console.ReadLine());
            
                    if(yards > 0)
                    {
                        inches = yards * inchesInYard; 
                        Console.WriteLine("The total number of inches is:{0}", inches);
                    }

                    else
                    {
                        Console.WriteLine("Please enter a value greater than 0.");
                    }

            

        }

    }
}
