using System;
using System.Collections.Generic;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(8);
            myGame.playGame();
        }
    }
}
