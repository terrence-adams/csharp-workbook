using System;
using System.Collections.Generic;
using System.Collections;



namespace TowersOfHanoi
{
    public class Tower
    {
       public Stack blocks = new Stack();

       public Tower()
       {
           

       }

       public void addToBlocks()
       {
           
       }

       public string Blocks{

           get{
               foreach(Block b in blocks)
               {
                   Console.WriteLine(b.Weight);
               }
               return "";
           }
       }
   
    }
}