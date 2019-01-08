using System;

namespace Variable_and_Operators
{
    class Program
    {
        public static void Main(public string[args])
    {
        int [] myArray =numberIntake();


        console.WriteLine(addOne(myArray[0], myArray[1]));
        


    }   


    public int [] numberIntake()
    {
        int x = 0;
        int y = 0;
        int [] sumArray = new int [x, y];
        Console.WriteLine("Please enter a number and press enter.");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a second number and press enter.");
        y = Convert.ToInt32(Console.ReadLine());

        return(sumArray);


    }
    public int addOne(int x , int y)
    {

        return(sum(x,y));

    }
    }
}
