using System;
using System.Linq;


namespace Checkers
{
    class Game
    {
        public Game()
        {
            
        }

        // method to start the game from main
        public void startGame()
        {

            
                Board myBoard = new Board();
                string nextMove = "";
                myBoard.DrawBoard();
                bool gameOver = false;

                while(!gameOver)
                {
                    Console.WriteLine("Do you want to 'move' or 'remove' a checker?");
                    nextMove = Console.ReadLine().ToLower();
                    if(nextMove == "move")
                    {
                        myBoard.moveCheckerOnBoard();
                        gameOver = myBoard.CheckForWin();
                    }
                    else if(nextMove == "remove")
                    {
                        myBoard.removeCheckerFromBoard();
                        gameOver = myBoard.CheckForWin();
                    }
                    //used to force a win
                    else if (nextMove == "x")
                    {
                        myBoard.forceWin();
                        Console.WriteLine("Black is the winner, congratulations.");
                        gameOver = myBoard.CheckForWin();
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry.");
                    
                    }
                   
                }

                Console.WriteLine("Game is over, thank you for playing.");
        }

    }









    
}