using System;
using System.Linq;

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



            int [] myArry2 = new int [] { 2,3,4,5,6,7,88,9};
            Console.WriteLine(myArry2.Where(x => x > 0).Select(mysqr.manualSquare).Sum());
        }
    }
}
