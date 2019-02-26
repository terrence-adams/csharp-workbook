using System;

namespace Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int []{2,3,4,5,6,7,8};
            Squares mysqr = new Squares();
            int mySum = mysqr.returnSquares(myArray);
            Console.WriteLine(mySum);
        }
    }
}
