using System;
using System.Collections;
using System.Collections.Generic;

namespace filehandling
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> q = new string [] {"words", "are", "important","2", "too"};
            Whiteboard wb = new Whiteboard();

            foreach(var i in wb.Filter(q))
            {

                Console.WriteLine(i.ToString());

            }
            
        }
    }
}
