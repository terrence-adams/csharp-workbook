using System;
using System.Collections;
using System.Collections.Generic;

namespace filehandling
{
    class Whiteboard
    {
        
        public System.Collections.Generic.IEnumerable<string> Filter(IEnumerable <string> S)
        {
           

            foreach(var item in S)
            {
                if(item.Length > 2)
                {
                   yield return item;

                }

            }
        


        }
    }
}
