using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var myValues = Enum.GetValues(typeof(Enums.Day));
           var myWeek = Enum.GetValues(typeof(Enums.Month));
           foreach(var v in myValues) 
           {
            Console.WriteLine(v);
           }
           foreach(var W in myWeek) 
           {
            Console.WriteLine(W);
           }
           

           
        }
    }
}
