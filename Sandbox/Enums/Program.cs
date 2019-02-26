using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var myValues = Enum.GetValues(typeof(Enums.Day));
           foreach(var v in myValues) 
           {
            Console.WriteLine(v);
           }
        }
    }
}
