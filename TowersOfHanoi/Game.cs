using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Game
    {
       
       Dictionary <string, Tower> towers = new Dictionary<string, Tower> ();

       public Game()
       {
           towers ["A"] = new Tower();
           towers ["B"] = new Tower();
           towers ["C"] = new Tower();

           Block four = new Block(4);
           Block three = new Block(3);
           Block two = new Block(2);
           Block one = new Block(1);
           
           Tower A = new Tower()
           


       }

    }
}