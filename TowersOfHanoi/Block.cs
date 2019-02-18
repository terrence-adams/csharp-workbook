using System;
namespace TowersOfHanoi
{
    class Block
    {
       int _weight = 0;
       public int Weight{
            get{
               return _weight;
           }

           private set
           {
               _weight = value;
           }
       }

       public Block(int myWeight)
       {
           Weight = myWeight;

       }

    }
}