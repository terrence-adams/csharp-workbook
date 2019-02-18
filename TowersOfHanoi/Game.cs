using System.Runtime.ExceptionServices;
using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Game
    {
       
       Dictionary <string, Tower> towers = new Dictionary<string, Tower> ();

       public Game()
       {

           Block four = new Block(4);
           Block three = new Block(3);
           Block two = new Block(2);
           Block one = new Block(1);
           Block five = new Block(5);
           Block six = new Block(6);



           Tower A = new Tower();
           Tower B = new Tower();
           Tower C = new Tower();

           A.blocks.Push(four);
           A.blocks.Push(three);
           A.blocks.Push(two);
           A.blocks.Push(one);
           
         

           towers ["A"] = A;
           towers ["B"] = new Tower();
           towers ["C"] = new Tower();

         

       }

       public void printBoard()
       {
           Console.WriteLine("Board:");
           Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
           foreach(KeyValuePair<string,Tower> item in towers )
           {
               var myTower = item.Value;
               Console.WriteLine("Tower: {0}",item.Key);
               Console.WriteLine(myTower.Blocks);
               

           }
           Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

       }

       public void MoviePiece(string popOff, string pushOn)
       {
           popOff.ToUpper();
           pushOn.ToUpper();

           if(popOff != null && pushOn != null && IsLegal(popOff, pushOn))
           {
               var piece = towers[popOff].blocks.Pop();
               towers[pushOn].blocks.Push(piece);

           }
           else
           {

               throw new ApplicationException("Invalid move!");

           }
        }

       private bool IsLegal(string popOff, string pushOn)
       {
           bool isLegalMove = false;

           try
           {
               if(towers[popOff].blocks.Count != 0 && towers[pushOn].blocks.Count != 0)
               {
                    Block blockWeightOff =(Block) towers[popOff].blocks.Peek();
                    Block blockWeightOn = (Block) towers[pushOn].blocks.Peek();
                    

                    if (blockWeightOff.Weight < blockWeightOn.Weight || blockWeightOn == null)
                    {
                        isLegalMove = true;
                    }

                    else
                    {
                        Console.WriteLine("Illegal move, try again.");
                    }

               }

               else if ( towers[popOff].blocks.Count > 0 || towers[pushOn].blocks.Count > 0)
               {

                   isLegalMove = true;

               }

               else
               {
                   Console.WriteLine("Illegal move, try again.");
               }

           }

           catch(InvalidCastException ex)
           {
               Console.WriteLine("Unable to get value successfully. {0}", ex);
           }

           return isLegalMove;

       }


       public bool CheckForWin()
       {
           if(towers["B"].blocks.Count ==4 || towers["C"].blocks.Count == 4 )
           {
               Console.WriteLine("You Won!");
               return true;

           }

           return false;


       }

       

       public void executeGame()
       {
           string moveFrom = "";
           string moveTo = "";

           bool playGame = true;

           while(playGame)
           {
            printBoard();
            Console.WriteLine("What tower to pick from ?");
            moveFrom = Console.ReadLine().ToString().ToUpper();
            Console.WriteLine("What tower to move to ?");
            moveTo = Console.ReadLine().ToString().ToUpper();

            if(IsLegal(moveFrom, moveTo))
                {
                    MoviePiece(moveFrom,moveTo);
                }
            else
               {
                   Console.WriteLine("Illegal move, try again.");
               }

                printBoard();
                playGame  = !(CheckForWin());
                
           }




       }

    }
}